﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HangFire_IRepository
{
   public interface IDbSession
    {
        /// <summary>
        /// 事物开始
        /// </summary>
        TransactionScope Begin();
        /// <summary>
        /// 事物完成
        /// </summary>
        void Complete();
        /// <summary>
        /// 是否立即提交数据库
        /// </summary>
        bool IsNotSubmit { get; set; }
        /// <summary>
        /// 将当前操作提交到数据库
        /// </summary>
        /// <returns></returns>
        int? SaveChanges();

        /// <summary>
        /// 执行sql增删改
        /// </summary>
        /// <param name="sql">需要执行的sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        int ExecuteSqlCommand(string sql, params object[] parameters);
        /// <summary>
        /// 执行sql查询
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="sql">需要执行的sql</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        List<T> SqlQuery<T>(string sql, params object[] parameters);

    }
}
