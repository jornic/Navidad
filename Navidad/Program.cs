using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Navidad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title="Parajon Jordy";
            Random random = new Random();

            for (int w = 1; w > 0; w++)
            {
                #region primer
                for (int i = 1; i < 8; i++) { 
                    String text = String.Empty;
                    int p = (i * 2) - 1;

                    for (int q = 0; q < 5; q++)
                    {
                        Console.Write(" ");
                    }
                    for (int q = 7; q > i; q--)
                    {
                        Console.Write(" ");
                    }

                    for (int a = 0; a < p; a++)
                    {
                      int n = random.Next(1, 4);
                      Console.ForegroundColor = color(n);
                        Console.Write("*");
                    }
                    Console.Write(text+"\n");
                }
                #endregion
                #region segundo
                for (int i = 6; i < 13; i++)
                {
                    String text = String.Empty;
                    int p = (i * 2) - 1;

                    for (int q = 12; q > i; q--)
                    {
                        Console.Write(" ");
                    }

                    for (int a = 0; a < p; a++)
                    {
                        int n = random.Next(1, 4);
                        Console.ForegroundColor = color(n);
                        Console.Write("*");
                    }
                    Console.Write(text + "\n");
                }
                #endregion 
                
                for(int y = 0; y < 2; y++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                   Console.WriteLine("         ****");
                }
                int g = random.Next(1, 4);
                Console.ForegroundColor = color(g);
                Console.WriteLine(mensaje(1));
                Console.WriteLine(mensaje(2));
                
                int l = random.Next(1, 4);
                Console.ForegroundColor = color(l);
            Console.Write("---------------------------Parajon Jordy ---- Jornic---------------------------");


                Thread.Sleep(300);
              Console.Clear();
              
            }
            Console.ReadKey();

        }

        static public ConsoleColor color(int n)
        {
            ConsoleColor a = ConsoleColor.Red;
            switch (n)
            {
                case 1:
                    a = ConsoleColor.Green;
                    break;
                case 2:
                    a = ConsoleColor.Red;
                    break;
                case 3:
                    a = ConsoleColor.Blue;
                    break;
                case 4:
                    a = ConsoleColor.DarkYellow;
                    break;

            }

            return a;
        }

        static public string mensaje(int q)
        {
            string a =string.Empty;
            switch (q)
            {
                case 1:
                    a = "}}}}}}}  }}}}}}}  }}     }}  }}}}}}}}}}}\n}}}}}}}  }}}}}}}  }}     }}         }}}\n}}       }}       }}     }}       }}}\n}}}}}}}  }}}}}}}  }}     }}     }}}}\n}}}}}}}  }}       }}     }}   }}}}\n}}       }}}}}}}  }}}}}} }}  }}}}\n}}       }}}}}}}  }}}}}} }} }}}}}}}}}}}}\n";
                    break;
                case 2:
                    a = "}}}}}}    }}}   }}}}}}   }}}       }}} }}}  }}}}}}}      }}}}}}   }}}}}}}\n}}} }}}}  }}}  }}}  }}}   }}}     }}}  }}}  }}}   }}}   }}}  }}}  }}}   }}}\n}}}  }}}} }}}  }}}}}}}}    }}}   }}}   }}}  }}}    }}}  }}}}}}}}  }}}    }}}\n}}}   }}}}}}}  }}}  }}}     }}} }}}    }}}  }}}  }}}}   }}}  }}}  }}}  }}}}\n}}}    }}}}}}  }}}  }}}      }}}}}     }}}  }}}}}}}     }}}  }}}  }}}}}}}\n";
                    break;
            }
            return a;
        }
    }
}
