using Son.Data.Repository;
using Son.Entities;
using Son.Model;
using Son.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son.Service
{
    public class ArticleManager:IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IResult Get(int articleId)
        {
            try
            {
                var article = _unitOfWork.ArticleRepository.Get(a => a.Id == articleId);
                if (article != null)
                {
                    ArticleDto articleDto = new ArticleDto()
                    {
                        Id = article.Id,
                        Title = article.Title,
                        Content = article.Content,
                    };
                    return new DataResult<ArticleDto>(articleDto, ResultStatus.Succes, "Başarılı");
                }
                else
                {
                    return new Result(ResultStatus.Succes, "Aradığınız Id'ye ait bir makale bulunamadı.");
                }
                

            }
            catch (Exception ex)
            {
                return new Result(ResultStatus.Error, "Başarısız",ex);
            }
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetAllByNonDeleted()
        {
            throw new NotImplementedException();
        }

        public void GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public void HardDelete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
