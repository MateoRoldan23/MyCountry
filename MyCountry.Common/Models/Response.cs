namespace MyCountry.Common.Model
{
    public class Response<Respo> where Respo: class
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public Respo Result { get; set; }
    }
}
