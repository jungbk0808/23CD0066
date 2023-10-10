
// W03MyEditView.h: CW03MyEditView 클래스의 인터페이스
//

#pragma once


class CW03MyEditView : public CEditView
{
protected: // serialization에서만 만들어집니다.
	CW03MyEditView() noexcept;
	DECLARE_DYNCREATE(CW03MyEditView)

// 특성입니다.
public:
	CW03MyEditDoc* GetDocument() const;

// 작업입니다.
public:

// 재정의입니다.
public:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// 구현입니다.
public:
	virtual ~CW03MyEditView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 생성된 메시지 맵 함수
protected:
	afx_msg void OnFilePrintPreview();
	afx_msg void OnRButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnContextMenu(CWnd* pWnd, CPoint point);
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // W03MyEditView.cpp의 디버그 버전
inline CW03MyEditDoc* CW03MyEditView::GetDocument() const
   { return reinterpret_cast<CW03MyEditDoc*>(m_pDocument); }
#endif

