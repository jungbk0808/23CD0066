
// W05FortressView.h: CW05FortressView 클래스의 인터페이스
//

#pragma once

#define GROUND 50

class CW05FortressView : public CView
{
protected:
	void CalculateCoordinate(int angle, int power, int t, int* x, int* y);
	void DrawBackground(CDC* pDC);

protected: // serialization에서만 만들어집니다.
	CW05FortressView() noexcept;
	DECLARE_DYNCREATE(CW05FortressView)

// 특성입니다.
public:
	CW05FortressDoc* GetDocument() const;

// 작업입니다.
public:

// 재정의입니다.
public:
	virtual void OnDraw(CDC* pDC);  // 이 뷰를 그리기 위해 재정의되었습니다.
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);

// 구현입니다.
public:
	virtual ~CW05FortressView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// 생성된 메시지 맵 함수
protected:
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnFire();
};

#ifndef _DEBUG  // W05FortressView.cpp의 디버그 버전
inline CW05FortressDoc* CW05FortressView::GetDocument() const
   { return reinterpret_cast<CW05FortressDoc*>(m_pDocument); }
#endif

