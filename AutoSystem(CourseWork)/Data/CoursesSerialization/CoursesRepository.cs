﻿using AutoSystem_CourseWork_.Data;
using AutoSystem_CourseWork_.Model;
using AutoSystem_CourseWork_.Model.Сourse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoSystem_CourseWork_.Data.CoursesSerialization
{
    public class CoursesRepository : IBaseRepository<ICourse>
    {
        private List<ICourse> _courses = new();
        private string path = string.Empty;

        public List<ICourse> GetCourses() => _courses;
        public CoursesRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Путь сохранения не задан или задан неверно!");
        }

        public bool Add(ICourse course)
        {
            if (course == null || _courses.Contains(course)) return false;
            var CheckSimilary = from selectCourse in _courses
                                where (course.Id == selectCourse.Id || course.Tests == selectCourse.Tests)
                                select course;
            if (CheckSimilary.Count() != 0) return false;
            _courses.Add(course);
            return true;
        }

        public bool Delete(ICourse course)
        {
            if (course == null) return false;
            if (_courses.Contains(course))
            {
                _courses.Remove(course);
                return true;
            }
            return false;
        }

        public bool Update(ICourse course)
        {
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == course.Id)
                {
                    _courses[i] = course;
                    return true;
                }
            }
            return false;
        }

        public bool FindCourse(ICourse course)
        {
            var CheckSimilary = from selectCourse in _courses
                                where (course.Id == selectCourse.Id)
                                select course;
            if (CheckSimilary.Count() == 0) return false;
            return true;
        }
        public ICourse UpdateMyCourse(ICourse course)
        {
            for (int i = 0; i < _courses.Count; i++)
            {
                if (course.Id == _courses[i].Id)
                {
                    course = _courses[i];
                    return course;
                }
            }
            return null;
        }

        public bool Save()
        {
            if (_courses == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            string saveJson = JsonConvert.SerializeObject(_courses, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            writer.Write(saveJson);
            return true;
        }

        public bool Load()
        {
            using var stream = File.Open(path, FileMode.Open);
            using var reader = new StreamReader(stream);
            string parseJson = reader.ReadToEnd();
            if (parseJson == null) return false;
            _courses = JsonConvert.DeserializeObject<List<ICourse>>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await Task.Run(Save);
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
