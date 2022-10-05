using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface INoticeDAL
    {
        //CRUD 구현

        //1. 공지사항 리스트 출력
        List<Notice> GetNoticeList(); // 객체 여러개를 리스트 형태로 가져온다

        //2. 공지사항 상세 출력
        Notice GetNotice(int noticeNo); // notice객체를 (primarykey인) noticeNo 를 가진 것을 반환

        //3. 공지사항 등록, 수정, 삭제
        bool InsertNotice(Notice notice);
        bool UpdateNotice(Notice notice);
        bool DeleteNotice(int noticeNo);

    }
}
