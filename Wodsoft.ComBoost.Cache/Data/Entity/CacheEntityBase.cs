﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Data.Entity
{
    /// <summary>
    /// 带缓存的实体基类
    /// </summary>
    public abstract class CacheEntityBase : EntityBase, ICacheEntity
    {
        /// <summary>
        /// 更新时间
        /// </summary>
        [Required]
        [Hide]
        [Column(TypeName = "datetime2")]
        public virtual DateTime UpdateTime { get { return (DateTime)GetValue(); } set { SetValue(value); } }

        [Hide]
        [NotMapped]
        public virtual CacheEntityState EntityState { get { return (CacheEntityState)GetValue(); } set { SetValue(value); } }

        public override void OnEditCompleted()
        {
            UpdateTime = DateTime.Now;
        }
    }
    
    public enum CacheEntityState
    {
        Normal = 0,
        Checking = 1,
        Updating = 2
    }
}
