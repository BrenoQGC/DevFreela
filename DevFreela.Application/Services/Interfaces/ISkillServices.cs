using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    internal interface ISkillServices
    {
        List<SkillViewModel> GetAll();
    }
}
