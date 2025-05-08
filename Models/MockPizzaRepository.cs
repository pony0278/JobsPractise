
namespace PizzaKing.Models;

public class MockPizzaRepository : IPizzaRepository
{
	public MockPizzaRepository() 
	{
		Initialize();
	}

	private List<Pizza> _pizzaList = new();

	private void Initialize()
	{
		_pizzaList =
		[
			new ("香腸披薩","全香腸") { Id = 1, Price = 12, LongDescription = "全是香腸", ImageUrl="/images/毛细.png"},
			new ("什錦披薩", "全都有") { Id = 2, Price = 10, LongDescription = "蔬菜什錦還有大魚大肉", ImageUrl="/images/细.png"},
			new ("起司披薩", "濃濃的起司起司") { Id = 3, Price = 11, LongDescription = "可以拉絲的起司披薩", ImageUrl="/images/三细.png"},
			new ("夏威夷披薩", "有鳳梨") { Id = 4,Price = 10, LongDescription = "義大利人的惡夢", ImageUrl="/images/二细.png"},
			new ("小龍蝦披薩", "辣小龍蝦口味") { Id = 5,Price = 11, LongDescription = "吃貨最愛", ImageUrl="/images/二柱子.png"},
			new ("鹹蛋黃蝦仁披薩","啥") { Id = 6,Price = 12, LongDescription = "亂掰", ImageUrl="/images/韭叶子.png"},
			new ("川式臘味披薩", "啥啥") { Id = 7,Price = 11, LongDescription = "亂掰", ImageUrl="/images/薄宽.png"},
			new ("螺獅粉披薩","臭臭的披薩") { Id = 8,Price = 10, LongDescription = "碳水爆炸", ImageUrl="/images/大宽.png"},
			new ("正宗義大利披薩", "番茄") { Id = 9,Price = 15, LongDescription = "可能也不太正宗", ImageUrl="/images/荞麦棱子.png"},
			new ("好吃的披薩", "從必勝客打包來的") { Id = 10,Price = 15, LongDescription = "好吃", ImageUrl="/images/一窝丝.png"}
		];
	}

    public IEnumerable<Pizza> GetAllPizzas()
    {
        return _pizzaList;
    }

    public Pizza? GetPizzaById(int id)
    {
        return _pizzaList.FirstOrDefault(p => p.Id == id);
    }
}