
## Felxbox
UIToolkit의 모든 요소는 Flexbox를 사용하여 레이아웃 됩니다.

1. 모든 요소가 가로 행 또는 세로 열에 배치됩니다.
1. 모든 것디 다른 요소를 담는 컨테이너가 될 수 있습니다.
1. 행과 열은 동일한 방식으로 동작합니다.
1. 행과 열 내에서 다음 세가지를 정의합니다
    - 각 항목의 초기 크기
    - 여유 공간이 있는 경우 늘어나는 정도
    - 공간이 요소보다 작은 경우 요소가 축소되는 정도
1. 각 항목에는 Padding 및 Margin도 있습니다.
1. 요소의 크기는 다음 중 하나로 지정할 수 있습니다.
    - 픽셀 값
    - 상위 요소의 비율(50% 등)
    - 글꼴 크기에 비례(UI의 텍스트가 많은 부분에 유용)
    - 화면 크기에 비례

## VisualElement

UIToolkit의 모든 요소는 VisualElement입니다. CSS는 화면의 모든 것을 HTML의 element에서 가져온 것으로 정의하기 때문에 UIToolkit에는 전체 UI에 대한 VisualElement 기본 클래스가 있습니다.

HTML/CSS에서는 무엇이든 다른 요소 안에 중첩될 수 있기 때문에 UIToolkit의 VisualElement는 항상 자식 VisualElement도 가질 수 있습니다.

## 우선순위

USS와 C#에서 동일한 스타일을 지정한 경우 C#의 스타일이 적용된다

## 시작하기

일반적으로 OnEnable 내부에 UIToolkit을 배치, EditorWIndow가 표시될 때 마다 우리는 GUI를 자동으로 생성할 것이다. 이 UIToolkit은 닫히거나, 파괴되거나, 다시 컴파일될 때 까지 유지될 것이다.




## Reference

https://flexbox4unity.com/2021/02/25/2021-uitoolkit-all-tutorials/