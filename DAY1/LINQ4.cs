
// grid.Children 은 Collection(List<UIElement>) 입니다.
// => 다양한 컨트롤을 보관하기 위해
// => 각 콘트롤의 기반 클래스인 UIElement 타입으로 보관
var col1 = grid.Children;


var collection = grid.Children.Cast<Image>(); 


Image? img1 = collection.FirstOrDefault(
                    img => Grid.GetRow(img) == y1 && Grid.GetColumn(img) == x1);

