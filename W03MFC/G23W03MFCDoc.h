
// G23W03MFCDoc.h: CG23W03MFCDoc 클래스의 인터페이스
//


#pragma once


class CG23W03MFCDoc : public CDocument
{
protected:
	CPoint Point = CPoint(- 100, -100); //생성자를 찾아가서 초기화 해야하는 경우도 있다.
protected: // serialization에서만 만들어집니다.
	CG23W03MFCDoc() noexcept;
	DECLARE_DYNCREATE(CG23W03MFCDoc)

// 특성입니다.
public:

// 작업입니다.
public:
	//getter, setter는 클래스 내부에서만 변경 가능하여 책임 소재 명확
	CPoint GetPoint() {
		return Point; //복사하여 주는 개념
	}
	void SetPoint(int x, int y) {
		Point.x = x;
		Point.y = y;
	}
	void SetPoint(CPoint Point) {
		this->Point = Point;
	}
// 재정의입니다.
public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
#ifdef SHARED_HANDLERS
	virtual void InitializeSearchContent();
	virtual void OnDrawThumbnail(CDC& dc, LPRECT lprcBounds);
#endif // SHARED_HANDLERS

// 구현입니다.
public:
	virtual ~CG23W03MFCDoc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:
// 생성된 메시지 맵 함수
protected:
	DECLARE_MESSAGE_MAP()

#ifdef SHARED_HANDLERS
	// 검색 처리기에 대한 검색 콘텐츠를 설정하는 도우미 함수
	void SetSearchContent(const CString& value);
#endif // SHARED_HANDLERS
};
