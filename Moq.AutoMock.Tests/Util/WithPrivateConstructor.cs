﻿namespace Moq.AutoMock.Tests
{
    class WithPrivateConstructor
    {
        public WithPrivateConstructor(IService1 service1) { }
        private WithPrivateConstructor(IService1 service1, IService2 service2) { }
    }
}
