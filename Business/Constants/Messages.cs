using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcud";
        public static string AccessTokenCreated = "Bağlantı jetonu oluşturuldu";

        public static string LessonAdded = "Ders eklendi";
        public static string LessonsListed = "Derslerler listelendi";
        public static string LessonUpdated = "Ders güncellendi";
        public static string LessonDeleted = "Ders silindi";

        public static string ClassAdded = "Sınıf eklendi";
        public static string ClassesListed = "Sınıflar listelendi";
        public static string ClassUpdated = "Sınıf güncellendi";
        public static string ClassDeleted = "Sınıf silindi";

        public static string StudentAdded = "Öğrenci eklendi";
        public static string StudentsListed = "Öğrenciler listelendi";
        public static string StudentUpdated = "Öğrenci güncellendi";
        public static string StudentDeleted = "Öğrenci silindi";

        public static string TeacherAdded = "Öğretmen eklendi";
        public static string TeachersListed = "Öğretmenler listelendi";
        public static string TeacherUpdated = "Öğretmen güncellendi";
        public static string TeacherDeleted = "Öğretmen silindi";

        public static string HomeworkAdded = "Ödev eklendi";
        public static string HomeworksListed = "Ödevler listelendi";
        public static string HomeworkUpdated = "Ödev güncellendi";
        public static string HomeworkDeleted = "Ödev silindi";

        public static string FileCreated { get; internal set; }
        public static string FileDeleted { get; internal set; }
    }
}
