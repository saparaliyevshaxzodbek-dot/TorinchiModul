using CreateTest.Api.Dtos;
using CreateTest.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CreateTest.Api.Controllers;

[Route("api/questions")]
[ApiController]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionService QuestionService;

    public QuestionsController()
    {
        QuestionService = new QuestionService();
    }

    [HttpPost("create")]
    public async Task<Guid> Add(QuestionCreateDto questionCreateDto)
    {
        return await QuestionService.CreateAsync(questionCreateDto);
    }

    [HttpDelete("delete/{id}")]
    public async Task Delete(Guid id)
    {
        await QuestionService.DeleteAsync(id); 
    }

    [HttpGet("{id}")]
    public async Task<QuestionGetDto> GetById(Guid id)
    {
        return await QuestionService.GetByIdAsync(id);
    }

    [HttpGet]
    public async Task<List<QuestionGetDto>>  GetAll()
    {
        return await QuestionService.GetAllAsync(); 
    }

    [HttpGet("solveQuestion")]
    public async Task<SolveReponseDto> SolveQuestion(Guid guid, string answer)
    {
        return  await QuestionService.SolveQuestionAsync(guid, answer);
    }

    [HttpGet("random")]
    public async Task<QuestionGetDto> GetRandom()
    {
        return await QuestionService.GetRandomQuestionAsync();
    }

    [HttpGet("count")]
    public async Task<int> Count()
    {
        return await QuestionService.GetCountOfQuestionsAsync();
    }

    [HttpPut("{id}")]
    public async Task Update(Guid id, QuestionCreateDto questionCreateDto)
    {
        await QuestionService.UpdateAsync(id, questionCreateDto);
    }




}
