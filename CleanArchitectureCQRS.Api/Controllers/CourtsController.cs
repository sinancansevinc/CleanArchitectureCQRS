﻿using CleanArchitectureCQRS.Application.Court.CreateCourt;
using CleanArchitectureCQRS.Application.Court.DeleteCourt;
using CleanArchitectureCQRS.Application.Court.GetCourt;
using CleanArchitectureCQRS.Application.Court.GetCourts;
using CleanArchitectureCQRS.Application.Court.UpdateCourt;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourtsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetCourtsRequest());

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourt(CreateCourtRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourt(int id)
        {
            var court = await _mediator.Send(new GetCourtRequest { Id = id });

            if (court is null)
            {
                return NotFound();
            }

            return Ok(court);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourt(int id, UpdateCourtRequest request)
        {

            if (id != request.Id)
            {
                return BadRequest();
            }

            var court = await _mediator.Send(request);

            return Ok(court);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCourt(int id)
        {
            var response = await _mediator.Send(new DeleteCourtRequest { Id = id });

            if (response.IsSuccess)
                    return Ok();

            return BadRequest();
            
        }
    }
}

