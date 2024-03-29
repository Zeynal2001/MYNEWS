﻿namespace MYNEWS.Entities
{
    public class Author : BaseEntity
    {
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; } //= string.Empty;
        public string? AuthorEmail { get; set; }
        public List<News> News { get; set; }
    }
}
