# WinformMVCApartmentViewApp
MVC 패턴을 적용한 Winform 부산 아파트 실거래가 윈도우 어플리케이션

- TargetURL, ServiceKey는 App.Config에서 불러오도록 처리
- ServiceKey AES 암호화 처리
- 암호화 처리하는 메소드는 클래스 라이브를 정의하여 처리(암호키 노출문제로 인함.)
- Trend 차트 정렬기준 IComparer상속받은 클래스를 생성하여 처리
- 모든 View MVC패턴 적용


** MVC 패턴 적용 구조
1. ViewForm 인스턴스 생성
2. Controller 인스턴스 생성
2-1. Controller는 인스턴스 생성시 항상 View를 파라미터로 넘겨받도록 설정 -> Controller에 View 연결
3. ViewForm은 공통 인터페이스 IControllerable을 상속받음
3-1. IControllerable은 IController를 파라미터로 넘겨받도록 설정 -> View에 Controller 연결

자세한 구조 소스는 WinformMVCExample 리포지토리 소스 확인요.


