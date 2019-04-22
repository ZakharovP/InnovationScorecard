namespace Lib
{
    public class Category
    {
        public string Text { private set; get; }
        public string Name { private set; get; }
        public string Description { private set; get; }
        public CategoryEnum Value { private set; get; }
        public Category(string text, string name, string desc, CategoryEnum value)
        {
            Text = text;
            Name = name;
            Description = desc;
            Value = value;
        }
        public Category(string text, string name, string desc)
        {
            Text = text;
            Name = name;
            Description = desc;
            Value = CategoryEnum.None;
        }
    }
}
