body{
    padding: 0;
    margin: 0;
}

#navbar>*{
    min-width: 1px;
    margin-right:2px ;
}
#logo{
    min-width: 1px;
}
#logoimage { 
    width: 100%;
    height: 60px;
} 

div { 
    flex: 1; 
} 
#loc{
    align-self: center;
    display: grid;
    position: relative;
    grid-template-columns: 40px 60px;
    grid-template-rows: 50px 50px;
    top: 50px;
}
#loclogo{
    display: inline;
    grid-row-start: 1;
    grid-row-end: 3;
}

#loc>i{
    grid-area: 1/1/2/3;
}
a{
    text-decoration: none;
    color: white;
}


p{
    display: inline;
}
#signup{
    width: 5px;
}
#count{
    width: 45px;
    background-color: black;
    color: white;
    border: none;
    min-width: 1px;
}
#country{
    width: 45px;
    flex: 0.5;
}
#signup{
    width: 100%;
}
#cart{
    display: flex;
    align-items: center;
    gap: 10px;
}
#subnav{
    display: flex;
    background-color: black;
    height: 40px;
}
#subnav>*
{
    color: white;
}
#subnav>div{
    flex: 1;
    flex-basis: 10px;
}
#all{
    display: flex;
}
#line{
    display: inline;
    align-items: center;
}