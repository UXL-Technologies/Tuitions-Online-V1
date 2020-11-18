﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuitionsOnline.Shared;

namespace TuitionsOnline.Server.DataAccessLayer
{
    public interface ITeacherAccessLayer
    {
        void AddTeacher(Teacher teacher);
        void AddContact(ContactToUs contact);

    }

    public class TeacherAccessLayer : ITeacherAccessLayer
    {
        private ApplicationDbContext _context;
        public TeacherAccessLayer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddContact(ContactToUs contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }
    }
}
