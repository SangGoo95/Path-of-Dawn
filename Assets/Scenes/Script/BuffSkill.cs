using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BUFF_TYPE
{
    ADDATKBUF,
    ADDDEFBUF,
    HEALBUF,
    TURNBUF
}


public class BuffSkill : Skill
{
    public BUFF_TYPE type;

    public new void Awake()
    {
        base.Awake();
    }


    public override void Cast()
    {
        if(type == BUFF_TYPE.ADDATKBUF)
        {
            //��� �÷��̾�� ĳ���� ���ݷ� ����
        }
        if(type == BUFF_TYPE.ADDDEFBUF)
        {
            //��� �÷��̾�� ĳ���� ���� ����
        }
        if(type == BUFF_TYPE.HEALBUF)
        {
            //��� �÷��̾�� ĳ���� ��
        }
        if(type == BUFF_TYPE.TURNBUF)
        {
            //�� �� ������..
        }
    }
}
