using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talYBProj.IFS
{
    public static class DBhelper
    {
        #region definitons
        private static dbEntities db;
        public static List<orderTBL> orderList;
        public static List<costomerTBL> costomerList;
        public static List<packTBL> packList;
        public static List<userTBL> userList;
        public static List<zanTBL> zanList;
        public static List<oilTBL> oilList;
        public static List<oliveTBL> oliveList;
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
            loadPackList();
            loadUserList();
            loadZanList();
            loadOilList();
            loadOliveList();
        }
        public static void loadOrderList()
        {
            orderList = (from s in db.orderTBL orderby s.totalPayment select s).ToList();
        }
        public static void loadCostomerList()
        {
            costomerList = (from s in db.costomerTBL orderby s.fullName select s).ToList();
        }

        public static void loadPackList()
        {
            packList = (from s in db.packTBL orderby s.price select s).ToList();
        }
        public static void loadUserList()
        {
            userList = (from s in db.userTBL orderby s.fullName select s).ToList();
        }
        public static void loadZanList()
        {
            zanList = (from s in db.zanTBL orderby s.name select s).ToList();
        }
        public static void loadOilList()
        {
            oilList = (from s in db.oilTBL orderby s.quantity select s).ToList();
        }
        public static void loadOliveList()
        {
            oliveList = (from s in db.oliveTBL orderby s.orderID select s).ToList();
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

        public static userTBL addUser(userTBL u1)
        {
            try
            {
                db.userTBL.Add(u1);
                db.SaveChanges();
                loadUserList();
                return u1;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static zanTBL addZan(zanTBL z1)
        {
            try
            {
                db.zanTBL.Add(z1);
                db.SaveChanges();
                loadZanList();
                return z1;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static oilTBL addOil(oilTBL o1)
        {
            try
            {
                db.oilTBL.Add(o1);
                db.SaveChanges();
                loadOilList();
                return o1;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static oliveTBL addOlive(oliveTBL o1)
        {
            try
            {
                db.oliveTBL.Add(o1);
                db.SaveChanges();
                loadOliveList();
                return o1;
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
        public static bool updateCostomer(costomerTBL c1)
        {
            try
            {
                costomerTBL toUpdate = (from s in db.costomerTBL where s.Id == c1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.firstName = c1.firstName;
                toUpdate.lastName = c1.lastName;
                toUpdate.companyName = c1.companyName;
                toUpdate.address = c1.address;
                toUpdate.cellPhone = c1.cellPhone;
                toUpdate.phone1 = c1.phone1;
                toUpdate.officePhone = c1.officePhone;
                toUpdate.email = c1.email;
                toUpdate.price = c1.price;
                toUpdate.notes = c1.notes;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updatePack(packTBL p1)
        {
            try
            {
                packTBL toUpdate = (from s in db.packTBL where s.Id == p1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.name = p1.name;
                toUpdate.volume = p1.volume;
                toUpdate.weight = p1.weight;
                toUpdate.price = p1.price;
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public static bool updateUser(userTBL u1)
        {
            try
            {
                userTBL toUpdate = (from s in db.userTBL where s.Id == u1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.firstName = u1.firstName;
                toUpdate.lastName = u1.lastName;
                toUpdate.email = u1.email;
                toUpdate.cellPhone = u1.cellPhone;
                toUpdate.lastLogIn = u1.lastLogIn;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool updateZan(zanTBL z1)
        {
            try
            {
                zanTBL toUpdate = (from s in db.zanTBL where s.Id == z1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.name = z1.name;
                toUpdate.orderID = z1.orderID;              
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool updateOil(oilTBL o1)
        {
            try
            {
                oilTBL toUpdate = (from s in db.oilTBL where s.Id == o1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.orderID = o1.orderID;
                toUpdate.PackID = o1.PackID;
                toUpdate.quantity = o1.quantity;
                toUpdate.weight = o1.weight;
                toUpdate.currDate = o1.currDate;
                toUpdate.packCharged = o1.packCharged;
                toUpdate.notes = o1.notes;
                toUpdate.userID = o1.userID;
                toUpdate.orderDate = o1.orderDate;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool updateOlive(oliveTBL o1)
        {
            try
            {
                oliveTBL toUpdate = (from s in db.oliveTBL where s.Id == o1.Id select s).FirstOrDefault();
                if (toUpdate != null)
                    return false;
                toUpdate.orderID = o1.orderID;
                toUpdate.dolevNum = o1.dolevNum;
                toUpdate.currDate = o1.currDate;
                toUpdate.weightBruto = o1.weightBruto;
                toUpdate.weightNeto = o1.weightNeto;
                toUpdate.notes = o1.notes;
                toUpdate.userID = o1.userID;
                toUpdate.orderDate = o1.orderDate;
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
