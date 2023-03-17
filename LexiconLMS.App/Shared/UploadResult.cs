﻿using System.ComponentModel.DataAnnotations;

namespace LexiconLMS.App.Shared
{
    public class UploadResult
    {
        [Key]
        public int id { get; set; }
        public bool Uploaded { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public int ErrorCode { get; set; }
        public string? FileType { get; set; }
    }
}
