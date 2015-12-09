using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;
using DataAccessLayer.Helpers;

namespace DataAccessLayer.Repository
{
    public class PictureRepository : ICrud<DomainModelPicture>
    {
        public List<DomainModelPicture> ReadAll()
        {
            using (var context = new Context.Context())
            {
                List<DomainModelPicture> pictureList = context.Picture.ToList();

                return pictureList;
            }
        }

        public DomainModelPicture Read(int Id)
        {
            DomainModelPicture picture = null;
            using (var context = new Context.Context())
            {
                picture = context.Picture.Where(DomainModelPicture => DomainModelPicture.Id == Id).FirstOrDefault();
            }
            return picture;
        }

        public void Create(DomainModelPicture entity)
        {
            using (var context = new Context.Context())
            {
                context.Set<DomainModelPicture>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var context = new Context.Context())
            {
                DomainModelPicture picture =
                    context.Set<DomainModelPicture>().Where(DomainModelPicture => DomainModelPicture.Id == Id).FirstOrDefault();
                if (picture != null)
                {
                    context.Set<DomainModelPicture>().Remove(picture);
                }
                context.SaveChanges();
            }
        }

        public DomainModelPicture Update(DomainModelPicture entity)
        {
            using (var context = new Context.Context())
            {
                DomainModelPicture picture =
                    context.Set<DomainModelPicture>().Where(DomainModelPicture => DomainModelPicture.Id == entity.Id).FirstOrDefault();
                if (picture != null)
                {
                    picture.Picture = entity.Picture;
                    picture.PictureName = entity.PictureName;
                }
                context.SaveChanges();
                return picture;
            }
        }
    }
}
