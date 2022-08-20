using SocialNetLibrary.Interfaces;

namespace SocialNetLibrary.Models
{
    public class User /*: IAppUser*/ //если будет использоваться интерфейс то как хранить в БД данные не определенные в интерфейсе
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? Age { get; set; }
        public string? City { get; set; }
    }
}