
// W04FileDoc.h: CW04FileDoc 클래스의 인터페이스
//


#pragma once


class CW04FileDoc : public CDocument
{
protected: // serialization에서만 만들어집니다.
	CW04FileDoc() noexcept;
	DECLARE_DYNCREATE(CW04FileDoc)

// 특성입니다.
public:

// 작업입니다.
public:
	CPoint GetPoint() { return Point; }
	void SetPoint(CPoint Point) {
		this->Point = Point;
		SetModifiedFlag(); //종료시 데이터 변경됐으면 파일 저장하겠냐 묻기
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
	virtual ~CW04FileDoc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:
	CPoint Point = CPoint(-100, -100);
// 생성된 메시지 맵 함수
protected:
	DECLARE_MESSAGE_MAP()

#ifdef SHARED_HANDLERS
	// 검색 처리기에 대한 검색 콘텐츠를 설정하는 도우미 함수
	void SetSearchContent(const CString& value);
#endif // SHARED_HANDLERS
};
