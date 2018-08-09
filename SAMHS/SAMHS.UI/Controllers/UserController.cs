using SAMHS.DAL.Interfaces;
using SAMHS.DAL.Metodos;
using SAMHS.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using System.Net;

namespace SAMHS.UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        IUser user;
        IUserType uType;
       
        public UserController()
        {
            user = new MUser();
            uType = new MUserType();
        
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UsersId()
        {
            var usuario = user.ListUsers();
            ViewBag.usuarioDll = new SelectList(usuario, "User_id", "User_name");
            return View();
        }
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User users)
        {
            if (users.User_id != 0)
            {
                Session["TheUserID"] = users.User_id;
                Session["UserType"] = users.User_type;
                var userToValidate = user.UserLogin(users.User_id, users.User_password);
                if (userToValidate == true)
                {
                    var userValue = user.SearchUser(users.User_id);
                    switch (userValue.User_type)
                    {
                        case 1:
                            return RedirectToAction("Index", "Home");
                        case 2:
                            return RedirectToAction("Mis_Proyectos");
                        case 3:
                            return RedirectToAction("AdminConsole");
                        case 4:
                            return RedirectToAction("Index", "Home");
                        default:
                            return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public ActionResult CreateMyAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMyAccount(User users)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                var userToAdd = Mapper.Map<DATA.User>(users);
                userToAdd.User_type = 2;
                user.AddUser(userToAdd);
                user.CreatedUserAccountSentEmail(users.User_email, users.User_name);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPost]
        public ActionResult CreateAccount(User users)
        {
            var listUserTypes = uType.ListUserTypes();
            ViewBag.listUserTypesDll = new SelectList(listUserTypes, "User_type_id", "User_type_name");

            if (users.User_name != null)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return View();
                    }

                    var userToAdd = Mapper.Map<DATA.User>(users);
                    user.AddUser(userToAdd);
                    //user.CreatedUserAccountSentEmail(users.User_email,users.User_name);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult UserProfileManagement()
        {
            var users = user.ListUsers();
            var usersToShow = Mapper.Map<List<Models.User>>(users);
            return View(usersToShow);
        }

        public ActionResult CreateUserAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUserAccount(User users)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var userToAdd = Mapper.Map<DATA.User>(users);
                user.AddUser(userToAdd);
                user.CreatedUserAccountSentEmail(users.User_email, users.User_name);
                return RedirectToAction("UserProfileManagement");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult EditUserAccount(int userId)
        {
            var usertoSearch = user.SearchUser(userId);
            var usersToShow = Mapper.Map<Models.User>(usertoSearch);
            return View(usersToShow);
        }
        [HttpPost]
        public ActionResult EditUserAccount(User users)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var userToEdit = Mapper.Map<DATA.User>(user);
                user.EditUser(userToEdit);
                return RedirectToAction("UserProfileManagement");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult DeleteUserAccount(int userId)
        {

            try
            {
                user.DeleteUser(userId);
                return RedirectToAction("UserProfileManagement");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult UserDetails(int userId)
        {
            var usertoSearch = user.SearchUser(userId);
            var usersToShow = Mapper.Map<Models.User>(usertoSearch);
            return View(usersToShow);
        }

       
        public ActionResult AdminConsole()
        {
            return View();
        }
    }
}