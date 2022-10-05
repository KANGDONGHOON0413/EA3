using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Note.DAL
{
    public class NoticeDAL : INoticeDAL
    {
        private readonly IConfiguration _confi; //appsettings의 connstring 을 이용하기위해 설정

        public NoticeDAL(IConfiguration confi)
        {
            _confi = confi;
        }

        //2. 공지사항 리스트 출력
        public List<Notice> GetNoticeList()
        {
            using (var db = new AspDbContext(_confi))       //매개변수도 appsettings의 connstring을 이용하기 위해 설정
            {
                return db.Table_Notice.ToList();
            }
        }

        //2. 공지사항 상세 출력
        public Notice GetNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }

        //2. 공지사항 삽,업,삭
        public bool InsertNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }
    }
}
