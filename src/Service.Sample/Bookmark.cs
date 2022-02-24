using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Domain
{
    public class Bookmark
    {
        public Category CategoryId { get; private set; }
        public string Name { get; private set; }
        public string URL { get; private set; }
        public bool NewTab { get; private set; }

        public Bookmark(Category categoryId, string name, string URL, bool newTab)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid name.");
            }

            this.CategoryId = categoryId;
            this.Name = name;
            this.URL = URL;
            this.NewTab = newTab;
        }

    }

    public enum Category
    {
        Sistemas = 1,
        Pessoas = 2,
        Noticias = 3,
        Normas = 4,
        Personalizado = 5,
        Outros = 6,
        Servicos = 7,
        Sharepoint = 8
    }
}
