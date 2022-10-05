using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class NoticeBLL 
    {
        private readonly INoticeDAL _noticeDAL;

        public NoticeBLL(INoticeDAL noticeDAL)
        {
            _noticeDAL = noticeDAL;
        }

           //공지 페이지 출력 2가지
        public Notice GetNotice(int noticeNo)
        {
            return _noticeDAL.GetNotice(noticeNo);
        }

        public List<Notice> GetNoticeList()
        {
            return _noticeDAL.GetNoticeList();
        }


        //공지 삽,업,삭
        public bool InsertNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException("null");
            return _noticeDAL.InsertNotice(notice);
        }

        public bool UpdateNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException("null");
            return _noticeDAL.UpdateNotice(notice);
        }

        public bool DeleteNotice(int noticeNo)
        {
            if (noticeNo == 0) throw new ArgumentNullException("null");
            return _noticeDAL.DeleteNotice(noticeNo);
        }

    }
}
