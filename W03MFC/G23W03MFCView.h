
// G23W03MFCView.h: CG23W03MFCView 클래스의 인터페이스
//

#pragma once


class CG23W03MFCView : public CView
{
protected: // serialization에서만 만들어집니다.
	CG23W03MFCView() noexcept;
	DECLARE_DYNCREATE(CG23W03MFCView)

// 특성입니다.
public:
	CG23W03MFCDoc* GetDocument() const;

// 작업입니다.
public:

// 재정의입니다.
public:
	//오버라이딩이 가능하다는 표시. 재정의를 위한 것.
	virtual void OnDraw(CDC* pDC);  // 이 뷰를 그리기 위해 재정의되었습니다.
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// 구현입니다.
public:
	virtual ~CG23W03MFCView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 생성된 메시지 맵 함수
protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
};

#ifndef _DEBUG  // G23W03MFCView.cpp의 디버그 버전
inline CG23W03MFCDoc* CG23W03MFCView::GetDocument() const
   { return reinterpret_cast<CG23W03MFCDoc*>(m_pDocument); }
#endif

