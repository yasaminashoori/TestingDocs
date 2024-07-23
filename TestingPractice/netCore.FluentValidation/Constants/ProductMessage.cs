namespace netCore.FluentValidation.Constants
{
    public static class ProductMessage
    {
        public const string NameIsRequired = "وارد کردن نام الزامی است";
        public const string NameLength = "نام باید بین 3 تا 50 کاراکتر باشد";
        public const string DescriptionIsRequired = "توضیحات اجباری است";
        public const string DescriptionLength = "توضیحات باید بین 3 تا 20 کاراکتر باشد.";
        public const string PriceIsRequired = "قیمت اجباری است.";
        public const string PriceGreaterThan = "قیمت باید بیشتر از 0 باشد.";
        public const string ProductNotFoundById = " Product not found by Id.";
    }
}
