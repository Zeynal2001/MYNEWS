namespace MYNEWS.Entities
{
    //Galiba hata bu koddan kaynaklanıyor.
    public class Comment : BaseEntity
    {
        public int? Vote { get; set; }
        public string CommentText { get; set; }
        //TODO: Login/Register'i quranda aşağıda olan nullable'ı sil.
        public Guid? NewsId { get; set; }
        public News News { get; set; }
        //Identity nin Id sini istifadə edirik deyə əlavə burada Guid AppUserId prop unu yazmırıq.
        //Sadəcə olaraq aşağıda AppUser navigation property'sini istifadə edərək relation'u quruq.
        //Və avtomatik olaraq Identity də olan (User)Id si də Comments cədvəlinə gəlmiş olacaq.
        public AppUser AppUser { get; set; }
    }
}
