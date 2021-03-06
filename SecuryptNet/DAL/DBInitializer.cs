﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SecuryptNet.Models;

namespace SecuryptNet.DAL
{
    //MVC EF framework class: if model changes, DB is dropped and recreated with test/dev data
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FileContext>
    {
        protected override void Seed(FileContext context)
        {
            var files = new List<EncryptedItem>
            {
                new EncryptedItem { Name = "FileOne", PublicKey = "uyGJT9THj(*&jyoiY7oj978JIGkUF&%^dvbrfJT^&%HJkiY", StorageLocation = "StorageOne"},
                new EncryptedItem { Name = "FileTwo", PublicKey = "uiHi786ht&%rujH&%6fug&^Tr5fh6r78TU&6TU76Ty&^Yt*", StorageLocation = "Storage2"},
                new EncryptedItem { Name = "File3", PublicKey = "IHJFYI*D&OFYJDK*&OFKiKLFJDSoLIFjfkhlKUFHJlkhgd", StorageLocation = "Storage3"},
                new EncryptedItem { Name = "File4", PublicKey = "o(K*UYI*&hu75RGY^4eHFGTYHGJYUKGIKfjytfgjnhtfnghm", StorageLocation = "Storage4"},
                new EncryptedItem { Name = "File4", PublicKey = "uyjthU&^%Rt78hrj*&67thgu7^RTGU7hytgh&U^TYU&^rt65yR&", StorageLocation = "Storage5"},
            };

            files.ForEach(f => context.EncryptedItems.Add(f));
            context.SaveChanges();
        }
    }
}