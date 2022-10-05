using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    //공지사항 model
    public class Notice
    {
        //공지사항 번호
        [Key]
        public int NoticeNo { get; set; }

        //공지사항 제목
        [Required]
        public string NoticeTitle { get; set; }

        //공지사항 내용
        [Required]
        public string NoticeContents { get; set; }


        // 공지사항 일자
        [Required]
        public DateTime NoticeTime { get; set; }
    }
}
