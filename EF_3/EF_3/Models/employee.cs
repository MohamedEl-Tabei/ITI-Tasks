﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_3.Models;

[Table("employee")]
public partial class employee
{
    [Key]
    [StringLength(9)]
    [Unicode(false)]
    public string emp_id { get; set; }

    [Required]
    [StringLength(20)]
    [Unicode(false)]
    public string fname { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string minit { get; set; }

    [Required]
    [StringLength(30)]
    [Unicode(false)]
    public string lname { get; set; }

    public short job_id { get; set; }

    public byte? job_lvl { get; set; }

    [Required]
    [StringLength(4)]
    [Unicode(false)]
    public string pub_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hire_date { get; set; }
}