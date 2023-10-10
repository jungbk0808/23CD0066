
// W03MyEditView.cpp: CW03MyEditView 클래스의 구현
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS는 미리 보기, 축소판 그림 및 검색 필터 처리기를 구현하는 ATL 프로젝트에서 정의할 수 있으며
// 해당 프로젝트와 문서 코드를 공유하도록 해 줍니다.
#ifndef SHARED_HANDLERS
#include "W03MyEdit.h"
#endif

#include "W03MyEditDoc.h"
#include "W03MyEditView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CW03MyEditView

IMPLEMENT_DYNCREATE(CW03MyEditView, CEditView)

BEGIN_MESSAGE_MAP(CW03MyEditView, CEditView)
	// 표준 인쇄 명령입니다.
	ON_COMMAND(ID_FILE_PRINT, &CEditView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CEditView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CW03MyEditView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CW03MyEditView 생성/소멸

CW03MyEditView::CW03MyEditView() noexcept
{
	// TODO: 여기에 생성 코드를 추가합니다.

}

CW03MyEditView::~CW03MyEditView()
{
}

BOOL CW03MyEditView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: CREATESTRUCT cs를 수정하여 여기에서
	//  Window 클래스 또는 스타일을 수정합니다.

	BOOL bPreCreated = CEditView::PreCreateWindow(cs);
	cs.style &= ~(ES_AUTOHSCROLL|WS_HSCROLL);	// 자동 래핑을 사용합니다.

	return bPreCreated;
}


// CW03MyEditView 인쇄


void CW03MyEditView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CW03MyEditView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 기본적인 CEditView 준비
	return CEditView::OnPreparePrinting(pInfo);
}

void CW03MyEditView::OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo)
{
	// 기본 CEditView 시작 인쇄
	CEditView::OnBeginPrinting(pDC, pInfo);
}

void CW03MyEditView::OnEndPrinting(CDC* pDC, CPrintInfo* pInfo)
{
	// 기본 CEditView 종료 인쇄
	CEditView::OnEndPrinting(pDC, pInfo);
}

void CW03MyEditView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CW03MyEditView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CW03MyEditView 진단

#ifdef _DEBUG
void CW03MyEditView::AssertValid() const
{
	CEditView::AssertValid();
}

void CW03MyEditView::Dump(CDumpContext& dc) const
{
	CEditView::Dump(dc);
}

CW03MyEditDoc* CW03MyEditView::GetDocument() const // 디버그되지 않은 버전은 인라인으로 지정됩니다.
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CW03MyEditDoc)));
	return (CW03MyEditDoc*)m_pDocument;
}
#endif //_DEBUG


// CW03MyEditView 메시지 처리기
