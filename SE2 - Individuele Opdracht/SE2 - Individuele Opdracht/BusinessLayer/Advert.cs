﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace SE2___Individuele_Opdracht
{
    /// <summary>
    /// deze class bewaard alle info over de Adverts uit de database
    /// </summary>
    public abstract class Advert
    {
        public int AdvertID { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int Views { get; set; }
        public bool IsService { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }

        public Advert(int advertID, string title, DateTime creationDate, int views, bool isService, int userID, int categoryID)
        {
            AdvertID = advertID;
            Title = title;
            CreationDate = creationDate;
            Views = views;
            IsService = isService;
            UserID = userID;
            CategoryID = categoryID;
        }
    }
}
