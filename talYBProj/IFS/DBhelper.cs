﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talYBProj.IFS
{
    internal class DBhelper
    {
        #region definitons
        private static dbEntities db;
        public static List<orderTBL> orderList;
        public static List<costomerTBL> costomerList;
        public static List<packTBL> packList;
        #endregion
        public static void init()
        {
            db = new dbEntities();
            loadall();
        }
        #region load function
        public static void loadall()
        {
            loadOrderList();
            loadCostomerList();
            LoadPackList();
        }
        public static void loadOrderList()
        {
            orderList = (from s in db.orderTBL orderby s.totalPayment select s).ToList();
        }
        public static void loadCostomerList()
        {
            costomerList = (from s in db.costomerTBL orderby s.fullName select s).ToList();
        }

        public static void LoadPackList()
        {
            packList = (from s in db.packTBL orderby s.price select s).ToList();
        }

        #endregion
        #region add function

        public static orderTBL addOrder(orderTBL o1)
        {
            try
            {
                db.orderTBL.Add(o1);
                db.SaveChanges();
                loadOrderList();
                return o1;
            }
            catch (Exception e)
            {
                string str = e.Message;
                return null;
            }
        }
        public static costomerTBL addCostomer(costomerTBL c1)
        {
            try
            {
                db.costomerTBL.Add(c1);
                db.SaveChanges();
                loadCostomerList();
                return c1;
            }
            catch (Exception e)
            {              
                return null;
            }
        }
        public static packTBL addPack(packTBL p1)
        {
            try
            {
                db.packTBL.Add(p1);
                db.SaveChanges();
                loadCostomerList();
                return p1;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
        #region update function

        public static bool updateOrder(orderTBL o1)
        {
            try
            {
                orderTBL toUpdate = (from s in db.orderTBL where s.Id == o1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.orderDate = o1.orderDate;
                toUpdate.zanID = o1.zanID;
                toUpdate.numOfDolevim = o1.numOfDolevim;
                toUpdate.isDone = o1.isDone;
                toUpdate.isPayd = o1.isPayd;
                toUpdate.userID = o1.userID;
                toUpdate.notes = o1.notes;
                toUpdate.totalPayment = o1.totalPayment;
                toUpdate.totalOlive = o1.totalOlive;
                toUpdate.totalOil = o1.totalOil;
                toUpdate.numOfOiPacks = o1.numOfOiPacks;
                toUpdate.orderPrice = o1.orderPrice;
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
      
    }
}
