# 🍕음식 레시피 관리 어플리케이션

## 📅 개발 기간
**2024/05/30 ~ 2024/06/18**

## 📖 소개
식재료를 효율적으로 관리하고, 다양한 레시피를 활용해 건강한 식생활을 유지하는 것은 매우 중요합니다. 많은 사람들이 재료의 유통기한을 놓치거나, 냉장고 속 재료들을 어떻게 활용할지 몰라 불필요한 낭비를 초래하곤 합니다. 이러한 문제를 해결하기 위해, 식재료 및 레시피 관리 프로그램을 개발하였습니다.

## 🔍 개발 내용

### 🗃️ 데이터 구조
- **Ingredient**: 재료를 저장하기 위한 구조.
  - 구성요소: DateTime(유통기한), Measurement(계량 단위)
- **IngredientMeasurement**: 재료의 계량 단위를 저장하기 위한 구조.
  - 구성요소: Name(재료 이름), Quantity(수량/용량), Unit(계량 단위)
- **Recipe**: 레시피 정보를 저장하기 위한 구조.
  - 구성요소: Name(재료 이름), Ingredients(레시피에 사용되는 음식 재료), Method(조리법)
- **CaloryInfo**: 레시피에 영양 정보를 저장하기 위한 구조.
  - 구성요소: Name(레시피 이름), Calories(음식 총 칼로리), Protein(단백질), Fat(지방), Carbohydrate(탄수화물)

### 💾 데이터베이스 클래스
- **변수**:
  - Delegate void DataChanged(): 등록된 데이터가 변경될 때 발생하는 델리게이트 정의
  - Dictionary<string, Recipe> Recipes: 이름을 키값으로 하는 레시피 딕셔너리
  - Dictionary<string, Ingredient> IngredientInventory: 이름과 유통기한을 키값으로 하는 재료 딕셔너리
  - Dictionary<Recipe, CaloryInfo> CaloryInfos: 레시피를 키값으로 하는 영양 정보 딕셔너리

- **메서드**:
  - Database 생성자: 초기 데이터 생성을 생성자에서 진행.
  - AddIngredient / AddRecipe / AddCaloryInfo: 각각의 딕셔너리에 데이터를 추가하는 메서드.
  - RemoveIngredient / RemoveRecipe: 입력된 키값에 따라 딕셔너리에서 데이터를 삭제하는 메서드.
  - LoadIngredientData / LoadRecipeData / LoadCaloryData: 역직렬화를 통해 데이터를 불러오는 메서드.

### 📐 데이터 포맷
- **IData 인터페이스**: Data 포맷임을 알려주기 위한 인터페이스.
  - RecipeData: IData 인터페이스를 상속하며, List<Recipe> 변수를 가짐.
  - IngredientData: IData 인터페이스를 상속하며, List<Ingredient> 변수를 가짐.
  - CaloryData: IData 인터페이스를 상속하며, List<CaloryInfo> 변수를 가짐.

## 💻 UI 구성
### 🍅 재료 관리 폼 (Ingredient Form)
- **기능**:
  - 재료 추가, 삭제, 수정
  - 유통기한 경고
  - 데이터 로드 및 저장

### 📜 레시피 관리 폼 (Recipe Form)
- **기능**:
  - 레시피 추가, 삭제, 수정
  - 레시피 재료 등록

### 🍽️ 음식 추천 폼 (Recommend Food Form)
- **기능**:
  - 보유 재료를 기반으로 레시피 추천
  - 부족한 재료 리스트 제공

### 🥗 영양 정보 계산 폼 (Calculate Calory Form)
- **기능**:
  - 레시피 영양 정보 확인
  - 하루 섭취 칼로리 계산

### 🛒 쇼핑 리스트 폼 (Shopping Form)
- **기능**:
  - 재료 구매 링크 제공
  - 장바구니 기능

## 📝 개발 결과
- 데이터가 생성되고 재료 폼이 로드됨.
- 유통기한 관련 알람 기능.
- 재료와 레시피 관리 기능.
- 영양 정보 계산 및 쇼핑 리스트 기능.

## 📚 참고자료
- 프로젝트 주제 선정 및 기능 리스트업을 위해 ChatGPT 활용.
- 더미 데이터 생성 및 코드 주석 작성에 ChatGPT 활용.
- 열거형 오류 해결을 위해 ChatGPT의 도움을 받음.
