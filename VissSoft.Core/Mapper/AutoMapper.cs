using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VissSoft.Core.DTOs.Responses.Course;
using VissSoft.Core.DTOs.Responses.Intro;
using VissSoft.Core.DTOs.Responses.NewAndEvent;
using VissSoft.Core.DTOs.Responses.Slide;
using VissSoft.Core.DTOs.Responses.Teacher;
using VissSoft.Core.Entities;

namespace VissSoft.Core.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<Course, CourseDTO>();
            CreateMap<Intro, IntroDTO>();
            CreateMap<NewAndEvent, NewAndEventDTO>();
            CreateMap<Slide, SlideDTO>();
            CreateMap<Teacher, TeacherDTO>();
        }
    }
}
