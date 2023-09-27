
// W04FileView.cpp: CW04FileView 클래스의 구현
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS는 미리 보기, 축소판 그림 및 검색 필터 처리기를 구현하는 ATL 프로젝트에서 정의할 수 있으며
// 해당 프로젝트와 문서 코드를 공유하도록 해 줍니다.
#ifndef SHARED_HANDLERS
#include "W04File.h"
#endif

#include "W04FileDoc.h"
#include "W04FileView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CW04FileView

IMPLEMENT_DYNCREATE(CW04FileView, CView)

BEGIN_MESSAGE_MAP(CW04FileView, CView)
	// 표준 인쇄 명령입니다.
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CView::OnFilePrintPreview)
	ON_WM_LBUTTONDOWN()
	ON_WM_RBUTTONDOWN()
	ON_WM_MOUSEMOVE()
END_MESSAGE_MAP()

// CW04FileView 생성/소멸

CW04FileView::CW04FileView() noexcept
{
	// TODO: 여기에 생성 코드를 추가합니다.

}

CW04FileView::~CW04FileView()
{
}

BOOL CW04FileView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: CREATESTRUCT cs를 수정하여 여기에서
	//  Window 클래스 또는 스타일을 수정합니다.

	return CView::PreCreateWindow(cs);
}

// CW04FileView 그리기

void CW04FileView::OnDraw(CDC* pDC)
{
	CW04FileDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: 여기에 원시 데이터에 대한 그리기 코드를 추가합니다.
	int n = pDoc->GetCount();
	for (int i = 0; i < n; i++) {
		CPoint p = pDoc->GetPoint(i);
		pDC->Ellipse(p.x - 30, p.y - 30, p.x + 30, p.y + 30);
	}
}


// CW04FileView 인쇄

BOOL CW04FileView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 기본적인 준비
	return DoPreparePrinting(pInfo);
}

void CW04FileView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 인쇄하기 전에 추가 초기화 작업을 추가합니다.
}

void CW04FileView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 인쇄 후 정리 작업을 추가합니다.
}


// CW04FileView 진단

#ifdef _DEBUG
void CW04FileView::AssertValid() const
{
	CView::AssertValid();
}

void CW04FileView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CW04FileDoc* CW04FileView::GetDocument() const // 디버그되지 않은 버전은 인라인으로 지정됩니다.
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CW04FileDoc)));
	return (CW04FileDoc*)m_pDocument;
}
#endif //_DEBUG


// CW04FileView 메시지 처리기


void CW04FileView::OnLButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	GetDocument()->AddPoint(point);
	Invalidate();

	CView::OnLButtonDown(nFlags, point);
}


void CW04FileView::OnRButtonDown(UINT nFlags, CPoint point)
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	GetDocument()->Undo();
	Invalidate();

	CView::OnRButtonDown(nFlags, point);
}


void CW04FileView::OnMouseMove(UINT nFlags, CPoint point)
{
	// TODO: 여기에 메시지 처리기 코드를 추가 및/또는 기본값을 호출합니다.
	if (nFlags & WM_LBUTTONDOWN) {
		GetDocument()->AddPoint(point);
		Invalidate();
	}

	CView::OnMouseMove(nFlags, point);
}
