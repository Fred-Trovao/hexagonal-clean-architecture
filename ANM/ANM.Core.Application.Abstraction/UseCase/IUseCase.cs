﻿using System.Threading.Tasks;

namespace ANM.Core.Application.Abstractions.UseCase
{
    /// <summary>
    /// Use Case.
    /// </summary>
    /// <typeparam name="TUseCaseInput">Any Input Message.</typeparam>
    public interface IUseCase<in TUseCaseInput>
        where TUseCaseInput : IUseCaseInput

    {
        /// <summary>
        /// Executes the Use Case.
        /// </summary>
        /// <param name="input">Input Message.</param>
        /// 
        /// <returns>Task.</returns>
        Task Execute(TUseCaseInput input);
    }
}
