﻿using _03BarracksFactory.Contracts;

namespace Barraks_Wars.Core.Commands
{
    //Applying the "Command Pattern" design pattern
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return this.data; }
            private set { this.data = value; }
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            private set { this.repository = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            private set { this.unitFactory = value; }
        }

        public abstract string Execute();
    }
}