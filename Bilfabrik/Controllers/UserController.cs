﻿using Bilfabrik.Models;
using Bilfabrik.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Bilfabrik.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/getallusers")]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _userService.GetallUsers();
        }

        [HttpPost("/adduser")]
        
        public ActionResult<List<User>> AddUser (User newUser)
        {
            return _userService.Add(newUser);
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpGet("{employeeType}")]

        

    }
}
