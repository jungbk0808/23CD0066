
// W05FortressView.cpp: CW05FortressView 클래스의 구현
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS는 미리 보기, 축소판 그림 및 검색 필터 처리기를 구현하는 ATL 프로젝트에서 정의할 수 있으며
// 해당 프로젝트와 문서 코드를 공유하도록 해 줍니다.
#ifndef SHARED_HANDLERS
#include "W05Fortress.h"
#endif

#include "W05FortressDoc.h"
#include "W05FortressView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CW05FortressView

IMPLEMENT_DYNCREATE(CW05FortressView, CView)

BEGIN_MESSAGE_MAP(CW05FortressView, CView)
	// 표준 인쇄 명령입니다.
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CView::OnFilePrintPreview)
	ON_COMMAND(IDM_FIRE, &CW05FortressView::OnFire)
	ON_WM_KEYDOWN()
END_MESSAGE_MAP()

// CW05FortressView 생성/소멸

CW05FortressView::CW05FortressView() noexcept
{
	// TODO: 여기에 생성 코드를 추가합니다.

}

CW05FortressView::~CW05FortressView()
{
}

BOOL CW05FortressView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: CREATESTRUCT cs를 수정하여 여기에서
	//  Window 클래스 또는 스타일을 수정합니다.

	return CView::PreCreateWindow(cs);
}

// CW05FortressView 그리기

void CW05FortressView::OnDraw(CDC* pDC)
{
	CW05FortressDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: 여기에 원시 데이터에 대한 그리기 코드를 추가합니다.
	DrawBackground(pDC);
}

void CW05FortressView::CalculateCoordinate(int angle, int power, int t, int* x, int* y)
{
	const double g = 9.8;
	const double pi = 3.141592;

	double theta = angle * pi / 180.;
	double v0 = (double)power;

	*x = (int)(v0 * t * cos(theta));
	*y = (int)(v0 * t * sin(theta) - g * t * t / 2.);
}

void CW05FortressView::DrawBackground(CDC* pDC)
{
	CRect rect;
	GetClientRect(&rect);
	pDC->MoveTo(rect.left, rect.bottom - GROUND);
	pDC->LineTo(rect.right, rect.bottom - GROUND);

	CW05FortressDoc* pDoc = GetDocument();
	int target = pDoc->GetTartget();
	pDC->Rectangle(target - TARGET_SIZE / 2, rect.bottom - GROUND - TARGET_SIZE,
		target + TARGET_SIZE / 2, rect.bottom - GROUND);

	CString str;
	str.Format(L"Angle = %d, Power = %d", pDoc->GetAngle(), pDoc->GetPower());
	pDC->TextOutW(10, 10, str);
}

// CW05FortressView 인쇄

BOOL CW05FortressView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 기본적인 준비
	return DoPreparePrinting(pInfo);
}

void CW05FortressView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 인쇄하기 전에 추가 초기화 작업을 추가합니다.
}

void CW05FortressView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 인쇄 후 정리 작업을 추가합니다.
}


// CW05FortressView 진단

#ifdef _DEBUG
void CW05FortressView::AssertValid() const
{
	CView::AssertValid();
}

void CW05FortressView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CW05FortressDoc* CW05FortressView::GetDocument() const // 디버그되지 않은 버전은 인라인으로 지정됩니다.
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CW05FortressDoc)));
	return (CW05FortressDoc*)m_pDocument;
}
#endif //_DEBUG


// CW05FortressView 메시지 처리기


void CW05FortressView::OnFire()
{
	// TODO: 여기에 명령 처리기 코드를 추가합니다.
	//MessageBox(L"발사");
	int x = 0, y = 0;
	CW05FortressDoc* pDoc = GetDocument();

	int a = pDoc->GetAngle();
	int p = pDoc->GetPower();
	int target = pDoc->GetTartget();

	CClientDC dc(this);

	CRect rect;
	GetClientRect(&rect);

	BeginWaitCursor(); //커서를 로딩 느낌으로

	CDC bmpDC;
	bmpDC.CreateCompatibleDC(&dc);

	CBitmap bmp;
	bmp.LoadBitmapW(IDB_BOMB);

	BITMAP info;
	bmp.GetBitmap(&info);

	CBitmap* old = bmpDC.SelectObject(&bmp);

	for (int t = 0; t < 100; t++) {
		CalculateCoordinate(a, p, t, &x, &y);

		y = rect.bottom - GROUND - y;
		//dc.Ellipse(x - BOMB_RADIUS, y - BOMB_RADIUS, x + BOMB_RADIUS, y + BOMB_RADIUS);
		
		dc.BitBlt(x - info.bmWidth / 2, y - info.bmHeight,
			info.bmWidth, info.bmHeight,
			&bmpDC,
			0, 0,
			SRCCOPY); //SRCAND는 투명

		if (y > rect.bottom - GROUND) 
			break;

		if (abs(x - target) < BOMB_RADIUS + TARGET_SIZE / 2 &&
			y > rect.bottom - GROUND - TARGET_SIZE - BOMB_RADIUS) {
			MessageBox(L"명중");
			break;
		}

		Sleep(50);

		dc.FillSolidRect(rect, RGB(255, 255, 255));
		DrawBackground(&dc);
	}

	bmpDC.SelectObject(old);

	EndWaitCursor();
}


void CW05FortressView::OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags)
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	CW05FortressDoc* pDoc = GetDocument();
	switch (nChar) {
	case VK_UP:
		pDoc->SetAngle(pDoc->GetAngle() + 1);
		break;
	case VK_DOWN:
		pDoc->SetAngle(pDoc->GetAngle() - 1);
		break;
	case VK_RIGHT:
		pDoc->SetPower(pDoc->GetPower() + 1);
		break;
	case VK_LEFT:
		pDoc->SetPower(pDoc->GetPower() - 1);
		break;
	}
	Invalidate();
	CView::OnKeyDown(nChar, nRepCnt, nFlags);
}
