﻿using System.ComponentModel.DataAnnotations;

namespace Task4Linkerp.ViewModel.Region
{
    public class DetailsRegionViewModel
    {
    

        public int Id { get; set; }
        [Display(Name = "Code")]
        public int Code { get; set; }
        [Display(Name = "Name(EN)")]
        [MinLength(3), MaxLength(200)]
        public string NameEN { get; set; }
        [Display(Name = "Name(AR)")]
        [MinLength(3), MaxLength(200)]
        public string NameAR { get; set; }
        public DetailsRegionViewModel(int id, int code, string nameEN, string nameAR)
        {
            Id = id;
            Code = code;
            NameEN = nameEN;
            NameAR = nameAR;
        }
    }
}
