﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Maplr.Cabane.Core.Interfaces;
using Maplr.Cabane.Core.ProjectAggregate;
using Maplr.Cabane.Core.ProjectAggregate.Events;
using Maplr.Cabane.Core.ProjectAggregate.Handlers;
using Moq;
using Xunit;

namespace Maplr.Cabane.UnitTests.Core.Handlers;

public class ItemCompletedEmailNotificationHandlerHandle
{
    private ItemCompletedEmailNotificationHandler _handler;
    private Mock<IEmailSender> _emailSenderMock;

    public ItemCompletedEmailNotificationHandlerHandle()
    {
        _emailSenderMock = new Mock<IEmailSender>();
        _handler = new ItemCompletedEmailNotificationHandler(_emailSenderMock.Object);
    }

    [Fact]
    public async Task ThrowsExceptionGivenNullEventArgument()
    {
        Exception ex = await Assert.ThrowsAsync<ArgumentNullException>(() => _handler.Handle(null, CancellationToken.None));
    }

    [Fact]
    public async Task SendsEmailGivenEventInstance()
    {
        await _handler.Handle(new ToDoItemCompletedEvent(new ToDoItem()), CancellationToken.None);

        _emailSenderMock.Verify(sender => sender.SendEmailAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}
