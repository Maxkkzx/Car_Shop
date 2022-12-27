namespace MyShop.Data.Models
{
    public class Car
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string ShortDesc { set; get; }

        public string LongDesc { set; get; }

        public string Img { set; get; }

        public ushort Price { set; get; }

        public bool IsFavourite { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
