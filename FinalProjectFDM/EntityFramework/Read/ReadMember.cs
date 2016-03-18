﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Read
{
    public class ReadMember
    {
        private GroupProjectEntities context;

        public ReadMember()
        {
            context = new GroupProjectEntities();
        }

        public ReadMember(GroupProjectEntities groupprojectEntities)
        {
            context = groupprojectEntities;
        }

        public List<Member> ReadAllUsers()
        {

            List<Member> _members = context.Members.ToList<Member>();
            return _members;
        }

        public Member ReadSpecificUser(int id)
        {
            Member noMemberFound = new Member()
            {
                //name = "User Does Not Exist"
            };

            if ((context.Members.SingleOrDefault(x => x.member_id == id)) != null)
            {
                Member _member = context.Members.Where<Member>(x => x.member_id == id).First();
                return _member;
            }
            else { return noMemberFound; }

        }

    }
}
