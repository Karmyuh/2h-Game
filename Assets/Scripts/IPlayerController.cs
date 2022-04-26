using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController 
{
    float HorizontalAxis { get;  }
    float VerticalAxis { get;  }
    float JumpAxis { get;  }
    
}
