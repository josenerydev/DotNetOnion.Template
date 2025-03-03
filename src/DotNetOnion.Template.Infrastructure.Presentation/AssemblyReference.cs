using System.Reflection;

namespace DotNetOnion.Template.Infrastructure.Presentation
{
    public static class AssemblyReference
    {
        public static Assembly PresentationAssembly => typeof(AssemblyReference).Assembly;
    }
}
