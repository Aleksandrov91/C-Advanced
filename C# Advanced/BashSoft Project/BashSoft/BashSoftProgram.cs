namespace BashSoft
{
    public class BashSoftProgram
    {
        public static void Main()
        {
            //IOManager.TraverseDirectory(@"D:\Development");
            StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            StudentsRepository.GetStudentScoreFromCourse("Unity", "Ivan");
        }
    }
}
