﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LTM.School.Core.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        public string RealName { get; set; }

        public DateTime EnrollmenDate { get; set; }

        public IComparable<Enrollment> Enrollments { get; set; }

    }
}