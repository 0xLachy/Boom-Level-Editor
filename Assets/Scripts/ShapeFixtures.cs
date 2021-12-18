using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Claunia.PropertyList;


public class ShapeFixtures
{
	public static void rotate_star(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(8) {
			new NSArray(2) {22.244995,24.019989},
			new NSArray(2) {-22.289993,23.859985},
			new NSArray(2) {-35.934998,-18.220001},
			new NSArray(2) {-43.649994,-63.710022},
			new NSArray(2) {-0.095001221,-44.765015},
			new NSArray(2) {36.320007,-18.704987},
			new NSArray(2) {68.899994,13.415009},
			new NSArray(2) {67.934998,17.079987}
		},
		new NSArray(4) {
			new NSArray(2) {-35.934998,-18.220001},
			new NSArray(2) {-22.289993,23.859985},
			new NSArray(2) {-68.089996,17.024994},
			new NSArray(2) {-69.050003,13.75}
		},
		new NSArray(4) {
			new NSArray(2) {-22.289993,23.859985},
			new NSArray(2) {22.244995,24.019989},
			new NSArray(2) {2.0899963,65.380005},
			new NSArray(2) {-1.3800049,65.380005}
		},
		new NSArray(3) {
			new NSArray(2) {-41.100006,-65.85498},
			new NSArray(2) {-0.095001221,-44.765015},
			new NSArray(2) {-43.649994,-63.710022}
		},
		new NSArray(4) {
			new NSArray(2) {-0.095001221,-44.765015},
			new NSArray(2) {41.404999,-65.659973},
			new NSArray(2) {43.665009,-63.844971},
			new NSArray(2) {36.320007,-18.704987}
		}
		});
	}

	public static void moving_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-59.959999,7.4550171},
			new NSArray(2) {-59.959999,-7.4500122},
			new NSArray(2) {59.949997,-7.4500122},
			new NSArray(2) {59.949997,7.4550171}
		}
		});
	}

    public static void factory_bit_dome(NSDictionary physProps)
    {
        physProps.Add("ShapeFixtures", new NSArray(4) {
        new NSArray(8) {
            new NSArray(2) {59.619995,-7.8099976},
            new NSArray(2) {-36.339996,20.695007},
            new NSArray(2) {-46.214996,12.789978},
            new NSArray(2) {-54.119995,2.3499756},
            new NSArray(2) {-59.764999,-7.8099976},
            new NSArray(2) {-64.914993,-32.400024},
            new NSArray(2) {64.859985,-32.400024},
            new NSArray(2) {63.390015,-18.554993}
        },
        new NSArray(3) {
            new NSArray(2) {-64.914993,-32.400024},
            new NSArray(2) {-59.764999,-7.8099976},
            new NSArray(2) {-63.309998,-18.474976}
        },
        new NSArray(8) {
            new NSArray(2) {46.640015,12.51001},
            new NSArray(2) {35.630005,21.825012},
            new NSArray(2) {24.059998,27.75},
            new NSArray(2) {9.1000061,31.700012},
            new NSArray(2) {-8.9600067,31.700012},
            new NSArray(2) {-36.339996,20.695007},
            new NSArray(2) {59.619995,-7.8099976},
            new NSArray(2) {54.540009,2.3499756}
        },
        new NSArray(3) {
            new NSArray(2) {-36.339996,20.695007},
            new NSArray(2) {-8.9600067,31.700012},
            new NSArray(2) {-25.330002,27.184998}
        }
        });
    }

    public static void boulder(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-9.5,-31},
			new NSArray(2) {6.5,-32},
			new NSArray(2) {22,-24},
			new NSArray(2) {29.5,-8},
			new NSArray(2) {28.5,8},
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {-32,-7.5},
			new NSArray(2) {-25.5,-23.5}
		},
		new NSArray(5) {
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {28.5,8},
			new NSArray(2) {24,24},
			new NSArray(2) {8,32.5},
			new NSArray(2) {-8,33.5}
		},
		new NSArray(3) {
			new NSArray(2) {-32,-7.5},
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {-33.5,8.5}
		}
		});
	}

	public static void statue_2(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(8) {
			new NSArray(2) {-33.459991,-24.690002},
			new NSArray(2) {33.330017,-24.690002},
			new NSArray(2) {33,-22.5},
			new NSArray(2) {30.695007,-16.845001},
			new NSArray(2) {27.585022,-11.044998},
			new NSArray(2) {24.950012,-8.8899994},
			new NSArray(2) {-24.605011,-3.0249939},
			new NSArray(2) {-31.424988,-16.309998}
		},
		new NSArray(3) {
			new NSArray(2) {-31.424988,-16.309998},
			new NSArray(2) {-24.605011,-3.0249939},
			new NSArray(2) {-28.670013,-8.5299988}
		},
		new NSArray(8) {
			new NSArray(2) {-23.765015,10.139999},
			new NSArray(2) {-24.605011,-3.0249939},
			new NSArray(2) {23.39502,-5.1799927},
			new NSArray(2) {5,24.949997},
			new NSArray(2) {-6.0499878,24.744995},
			new NSArray(2) {-13,23},
			new NSArray(2) {-17.660004,19.835007},
			new NSArray(2) {-21.48999,14.809998}
		},
		new NSArray(3) {
			new NSArray(2) {-24.605011,-3.0249939},
			new NSArray(2) {24.950012,-8.8899994},
			new NSArray(2) {23.39502,-5.1799927}
		},
		new NSArray(6) {
			new NSArray(2) {12.980011,22.229996},
			new NSArray(2) {5,24.949997},
			new NSArray(2) {23.39502,-5.1799927},
			new NSArray(2) {24.234985,11.220001},
			new NSArray(2) {20.5,17.5},
			new NSArray(2) {17,20.5}
		}
		});
	}

	public static void statue_3(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(8) {
			new NSArray(2) {43.5,-25.5},
			new NSArray(2) {40.279999,-16.070007},
			new NSArray(2) {36.329987,-7.2099915},
			new NSArray(2) {30.605011,-2.0899963},
			new NSArray(2) {-46,-31},
			new NSArray(2) {-46.359985,-40.709991},
			new NSArray(2) {46.285004,-40.709991},
			new NSArray(2) {45.665009,-33.640015}
		},
		new NSArray(8) {
			new NSArray(2) {-41.5,-10},
			new NSArray(2) {-44.5,-22},
			new NSArray(2) {-46,-31},
			new NSArray(2) {30.605011,-2.0899963},
			new NSArray(2) {29.765015,2.9349976},
			new NSArray(2) {4.5,40.950012},
			new NSArray(2) {-32.714996,5.0750122},
			new NSArray(2) {-36.665009,0.76501465}
		},
		new NSArray(7) {
			new NSArray(2) {18,37},
			new NSArray(2) {12.529999,38.725006},
			new NSArray(2) {4.5,40.950012},
			new NSArray(2) {29.765015,2.9349976},
			new NSArray(2) {30.5,23},
			new NSArray(2) {27.609985,29.029999},
			new NSArray(2) {23,34}
		},
		new NSArray(8) {
			new NSArray(2) {-26.730011,30.825012},
			new NSArray(2) {-30.559998,24.720001},
			new NSArray(2) {-32.954987,15.024994},
			new NSArray(2) {-32.714996,5.0750122},
			new NSArray(2) {4.5,40.950012},
			new NSArray(2) {-8,41},
			new NSArray(2) {-16.915009,38.244995},
			new NSArray(2) {-23.26001,35.015015}
		}
		});
	}

	public static void factory_bit_thin(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-44.920013,7.4299927},
			new NSArray(2) {-44.920013,-7.414978},
			new NSArray(2) {44.904999,-7.414978},
			new NSArray(2) {44.904999,7.4299927}
		}
		});
	}

	public static void pyramid_pyramid(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-59.035004,-38.524994},
			new NSArray(2) {59.079987,-38.100006},
			new NSArray(2) {0.13000488,38.024994}
		}
		});
	}

	public static void rotate_hexagon(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(6) {
			new NSArray(2) {35.63501,-62.214996},
			new NSArray(2) {71.910004,0.1000061},
			new NSArray(2) {35.804993,62.119995},
			new NSArray(2) {-35.949997,62.119995},
			new NSArray(2) {-72.205002,-0.23999023},
			new NSArray(2) {-36.345001,-62.214996}
		}
		});
	}

	public static void cage_bottom(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(4) {
			new NSArray(2) {-24.255005,-36.945007},
			new NSArray(2) {-11.244995,-40.919983},
			new NSArray(2) {-11.295013,-34.650024},
			new NSArray(2) {-23.795013,-32.150024}
		},
		new NSArray(5) {
			new NSArray(2) {11.204987,-34.650024},
			new NSArray(2) {-11.244995,-40.919983},
			new NSArray(2) {11.704987,-40.650024},
			new NSArray(2) {22.704987,-37.650024},
			new NSArray(2) {22.704987,-32.650024}
		},
		new NSArray(3) {
			new NSArray(2) {-11.244995,-40.919983},
			new NSArray(2) {11.204987,-34.650024},
			new NSArray(2) {-11.295013,-34.650024}
		}
		});
	}

	public static void PU_rocket_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(6) {
			new NSArray(2) {44.005005,-4.2050171},
			new NSArray(2) {48.605011,1.9349976},
			new NSArray(2) {32.339996,11.755005},
			new NSArray(2) {28.355011,8.0700073},
			new NSArray(2) {21.600006,-10.034973},
			new NSArray(2) {27.429993,-13.409973}
		},
		new NSArray(5) {
			new NSArray(2) {-17.679993,-13.719971},
			new NSArray(2) {-4.7900085,-9.7299805},
			new NSArray(2) {-1.7200012,8.0700073},
			new NSArray(2) {-14.304993,9.6049805},
			new NSArray(2) {-44.070007,0.40002441}
		},
		new NSArray(4) {
			new NSArray(2) {-4.7900085,-9.7299805},
			new NSArray(2) {21.600006,-10.034973},
			new NSArray(2) {28.355011,8.0700073},
			new NSArray(2) {-1.7200012,8.0700073}
		}
		});
	}

	public static void frozen_statue_2(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {-46.505005,-47.700012},
			new NSArray(2) {46.994995,-47.200012},
			new NSArray(2) {43.994995,-22.200012},
			new NSArray(2) {34.494995,0.29998779},
			new NSArray(2) {29.494995,8.2999878},
			new NSArray(2) {-32.005005,10.799988},
			new NSArray(2) {-37.005005,2.7999878},
			new NSArray(2) {-44.005005,-22.700012}
		},
		new NSArray(8) {
			new NSArray(2) {9.4949951,44.799988},
			new NSArray(2) {-6.0050049,46.299988},
			new NSArray(2) {-21.505005,41.299988},
			new NSArray(2) {-29.005005,28.299988},
			new NSArray(2) {-32.005005,10.799988},
			new NSArray(2) {29.494995,8.2999878},
			new NSArray(2) {30.494995,27.799988},
			new NSArray(2) {21.494995,39.799988}
		}
		});
	}

	public static void pyramid_brick_light(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {46.230011,-14.730011},
			new NSArray(2) {46.234985,14.804993},
			new NSArray(2) {-46.299988,14.785004},
			new NSArray(2) {-46.309998,-14.714996}
		}
		});
	}

	public static void boulder_snow(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-9.5,-31},
			new NSArray(2) {6.5,-32},
			new NSArray(2) {22,-24},
			new NSArray(2) {29.5,-8},
			new NSArray(2) {28.5,8},
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {-32,-7.5},
			new NSArray(2) {-25.5,-23.5}
		},
		new NSArray(5) {
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {28.5,8},
			new NSArray(2) {24,24},
			new NSArray(2) {8,32.5},
			new NSArray(2) {-8,33.5}
		},
		new NSArray(3) {
			new NSArray(2) {-32,-7.5},
			new NSArray(2) {-22.5,24.5},
			new NSArray(2) {-33.5,8.5}
		}
		});
	}

	public static void barrel_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-29.450012,-45.470001},
			new NSArray(2) {1.0150146,-45.079987},
			new NSArray(2) {37.914978,-19.565002},
			new NSArray(2) {37.914978,18.179993},
			new NSArray(2) {1.2250061,44.815002},
			new NSArray(2) {-29.730011,45.130005},
			new NSArray(2) {-37.575012,18.179993},
			new NSArray(2) {-37.575012,-19.355011}
		},
		new NSArray(3) {
			new NSArray(2) {29.255005,-45.470001},
			new NSArray(2) {37.914978,-19.565002},
			new NSArray(2) {1.0150146,-45.079987}
		},
		new NSArray(3) {
			new NSArray(2) {1.2250061,44.815002},
			new NSArray(2) {37.914978,18.179993},
			new NSArray(2) {29.540009,45.410004}
		}
		});
	}

	public static void tree_big(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(3) {
			new NSArray(2) {21.910004,-65.609985},
			new NSArray(2) {50.550003,-58.335022},
			new NSArray(2) {49.184998,-43.789978}
		},
		new NSArray(5) {
			new NSArray(2) {-46.270004,-69.700012},
			new NSArray(2) {-34.904999,-71.065002},
			new NSArray(2) {-22.634995,-64.700012},
			new NSArray(2) {-38.544998,-30.155029},
			new NSArray(2) {-50.360001,-61.974976}
		},
		new NSArray(6) {
			new NSArray(2) {49.184998,-43.789978},
			new NSArray(2) {49.639999,-35.155029},
			new NSArray(2) {39.639999,-11.974976},
			new NSArray(2) {-7.6349945,-66.52002},
			new NSArray(2) {-9.9049988,-83.789978},
			new NSArray(2) {21.910004,-65.609985}
		},
		new NSArray(8) {
			new NSArray(2) {-22.634995,-64.700012},
			new NSArray(2) {-7.6349945,-66.52002},
			new NSArray(2) {39.639999,-11.974976},
			new NSArray(2) {42.820007,-5.6099854},
			new NSArray(2) {40.550003,2.5700073},
			new NSArray(2) {33.274994,23.47998},
			new NSArray(2) {-26.725006,18.47998},
			new NSArray(2) {-38.544998,-30.155029}
		},
		new NSArray(3) {
			new NSArray(2) {-38.544998,-30.155029},
			new NSArray(2) {-26.725006,18.47998},
			new NSArray(2) {-42.179993,-22.880005}
		},
		new NSArray(3) {
			new NSArray(2) {-9.9049988,-83.789978},
			new NSArray(2) {25.095001,-83.335022},
			new NSArray(2) {21.910004,-65.609985}
		},
		new NSArray(3) {
			new NSArray(2) {40.550003,2.5700073},
			new NSArray(2) {41,6.664978},
			new NSArray(2) {33.274994,23.47998}
		},
		new NSArray(5) {
			new NSArray(2) {33.274994,23.47998},
			new NSArray(2) {34.639999,30.299988},
			new NSArray(2) {32.365005,37.570007},
			new NSArray(2) {-29.904999,26.664978},
			new NSArray(2) {-26.725006,18.47998}
		},
		new NSArray(5) {
			new NSArray(2) {-0.36000061,81.664978},
			new NSArray(2) {-29.904999,26.664978},
			new NSArray(2) {32.365005,37.570007},
			new NSArray(2) {31.910004,45.299988},
			new NSArray(2) {8.7299957,81.664978}
		}
		});
	}

	public static void rotate_cog(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(8) {
		new NSArray(4) {
			new NSArray(2) {50.420013,11.434998},
			new NSArray(2) {71.369995,28.41},
			new NSArray(2) {61.825012,45.16},
			new NSArray(2) {35,38}
		},
		new NSArray(4) {
			new NSArray(2) {60.174988,-47.120003},
			new NSArray(2) {70.565002,-30.974998},
			new NSArray(2) {50.420013,-10.620003},
			new NSArray(2) {34.940002,-37.790001}
		},
		new NSArray(4) {
			new NSArray(2) {-62.300003,-44.800003},
			new NSArray(2) {-34.860001,-37.324997},
			new NSArray(2) {-50.425003,-10.870003},
			new NSArray(2) {-70.779999,-28.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-50.425003,11.470001},
			new NSArray(2) {-34.865005,38.375},
			new NSArray(2) {-60.949997,47.279999},
			new NSArray(2) {-70.490005,30.950001}
		},
		new NSArray(8) {
			new NSArray(2) {-50.425003,-10.870003},
			new NSArray(2) {-34.860001,-37.324997},
			new NSArray(2) {-15.985001,-48.349998},
			new NSArray(2) {15.01001,-48.394997},
			new NSArray(2) {15.600006,48.974998},
			new NSArray(2) {-15.994995,48.764999},
			new NSArray(2) {-34.865005,38.375},
			new NSArray(2) {-50.425003,11.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-11.320007,-75.705002},
			new NSArray(2) {8.3999939,-75.705002},
			new NSArray(2) {15.01001,-48.394997},
			new NSArray(2) {-15.985001,-48.349998}
		},
		new NSArray(6) {
			new NSArray(2) {34.940002,-37.790001},
			new NSArray(2) {50.420013,-10.620003},
			new NSArray(2) {50.420013,11.434998},
			new NSArray(2) {35,38},
			new NSArray(2) {15.600006,48.974998},
			new NSArray(2) {15.01001,-48.394997}
		},
		new NSArray(4) {
			new NSArray(2) {-15.994995,48.764999},
			new NSArray(2) {15.600006,48.974998},
			new NSArray(2) {9.875,76.120003},
			new NSArray(2) {-7.9349976,76.120003}
		}
		});
	}

	public static void tree_small(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(8) {
			new NSArray(2) {33.080002,-33.974976},
			new NSArray(2) {43.535004,-18.974976},
			new NSArray(2) {51.720001,-1.25},
			new NSArray(2) {41.264999,29.205017},
			new NSArray(2) {-44.190002,20.11499},
			new NSArray(2) {-28.279999,-33.974976},
			new NSArray(2) {-9.6450043,-43.974976},
			new NSArray(2) {13.080002,-43.974976}
		},
		new NSArray(4) {
			new NSArray(2) {-42.375,-37.609985},
			new NSArray(2) {-28.279999,-33.974976},
			new NSArray(2) {-44.190002,20.11499},
			new NSArray(2) {-51.464996,-17.155029}
		},
		new NSArray(3) {
			new NSArray(2) {48.080002,-18.52002},
			new NSArray(2) {51.720001,-1.25},
			new NSArray(2) {43.535004,-18.974976}
		},
		new NSArray(5) {
			new NSArray(2) {-18.735001,48.294983},
			new NSArray(2) {-44.190002,20.11499},
			new NSArray(2) {41.264999,29.205017},
			new NSArray(2) {23.535004,48.294983},
			new NSArray(2) {2.1699982,55.11499}
		},
		new NSArray(4) {
			new NSArray(2) {-11.464996,-55.340027},
			new NSArray(2) {15.354996,-54.88501},
			new NSArray(2) {13.080002,-43.974976},
			new NSArray(2) {-9.6450043,-43.974976}
		}
		});
	}

	public static void nails(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(3) {
			new NSArray(2) {15.48999,1.8950195},
			new NSArray(2) {24.809998,-6.2700195},
			new NSArray(2) {20.184998,3.4000244}
		},
		new NSArray(5) {
			new NSArray(2) {5.5299988,1.8950195},
			new NSArray(2) {-4.7999878,1.4500122},
			new NSArray(2) {-24.714996,-6.2800293},
			new NSArray(2) {24.809998,-6.2700195},
			new NSArray(2) {15.48999,1.8950195}
		},
		new NSArray(3) {
			new NSArray(2) {-24.714996,-6.2800293},
			new NSArray(2) {-14.684998,1.0800171},
			new NSArray(2) {-19.595001,3.4000244}
		},
		new NSArray(4) {
			new NSArray(2) {-14.684998,1.0800171},
			new NSArray(2) {-24.714996,-6.2800293},
			new NSArray(2) {-4.7999878,1.4500122},
			new NSArray(2) {-9.9249878,3.3850098}
		},
		new NSArray(3) {
			new NSArray(2) {5.5299988,1.8950195},
			new NSArray(2) {15.48999,1.8950195},
			new NSArray(2) {10.140015,3.3850098}
		},
		new NSArray(3) {
			new NSArray(2) {-4.7999878,1.4500122},
			new NSArray(2) {5.5299988,1.8950195},
			new NSArray(2) {0.17999268,3.3850098}
		}
		});
	}

	public static void pyramid_urn(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(8) {
			new NSArray(2) {25.109985,-7.5999756},
			new NSArray(2) {25.299988,8.4000244},
			new NSArray(2) {23.76001,13.215027},
			new NSArray(2) {-23.470001,15.340027},
			new NSArray(2) {-25.589996,10.325012},
			new NSArray(2) {-25.394989,-6.8300171},
			new NSArray(2) {-15.76001,-28.22998},
			new NSArray(2) {14.315002,-28.419983}
		},
		new NSArray(6) {
			new NSArray(2) {-21.734985,23.434998},
			new NSArray(2) {-23.470001,15.340027},
			new NSArray(2) {21.445007,22.280029},
			new NSArray(2) {21.059998,31.340027},
			new NSArray(2) {17.015015,40.590027},
			new NSArray(2) {-16.334991,40.590027}
		},
		new NSArray(3) {
			new NSArray(2) {-23.470001,15.340027},
			new NSArray(2) {-21.734985,23.434998},
			new NSArray(2) {-24.23999,17.844971}
		},
		new NSArray(4) {
			new NSArray(2) {12.964996,-41.14502},
			new NSArray(2) {14.315002,-28.419983},
			new NSArray(2) {-15.76001,-28.22998},
			new NSArray(2) {-15.950012,-41.335022}
		},
		new NSArray(3) {
			new NSArray(2) {-21.734985,23.434998},
			new NSArray(2) {-16.334991,40.590027},
			new NSArray(2) {-21.154999,32.494995}
		},
		new NSArray(4) {
			new NSArray(2) {-23.470001,15.340027},
			new NSArray(2) {23.76001,13.215027},
			new NSArray(2) {23.954987,16.299988},
			new NSArray(2) {21.445007,22.280029}
		}
		});
	}

	public static void pyramid_sarcophagus(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(8) {
			new NSArray(2) {-24.369995,44.84},
			new NSArray(2) {28.594971,27.185001},
			new NSArray(2) {25.590027,45.220001},
			new NSArray(2) {18.080017,76.775002},
			new NSArray(2) {-1.0799866,82.035004},
			new NSArray(2) {-13.850006,78.650002},
			new NSArray(2) {-17.984985,77.150002},
			new NSArray(2) {-28.505005,47.470001}
		},
		new NSArray(8) {
			new NSArray(2) {-27.75,24.18},
			new NSArray(2) {-29.255005,0.51499939},
			new NSArray(2) {-17.984985,-66.729996},
			new NSArray(2) {18.080017,-65.600006},
			new NSArray(2) {29.349976,-0.98999786},
			new NSArray(2) {29.724976,20.425003},
			new NSArray(2) {28.594971,27.185001},
			new NSArray(2) {-24.369995,44.84}
		},
		new NSArray(3) {
			new NSArray(2) {-29.255005,0.51499939},
			new NSArray(2) {-27.75,24.18},
			new NSArray(2) {-29.255005,20.799999}
		},
		new NSArray(4) {
			new NSArray(2) {-27.75,24.18},
			new NSArray(2) {-24.369995,44.84},
			new NSArray(2) {-27.75,42.215},
			new NSArray(2) {-28.880005,29.814999}
		},
		new NSArray(4) {
			new NSArray(2) {-17.984985,-66.729996},
			new NSArray(2) {-21.36499,-82.130005},
			new NSArray(2) {20.335022,-81.755005},
			new NSArray(2) {18.080017,-65.600006}
		},
		new NSArray(3) {
			new NSArray(2) {28.594971,27.185001},
			new NSArray(2) {29.349976,32.82},
			new NSArray(2) {25.590027,45.220001}
		},
		new NSArray(3) {
			new NSArray(2) {25.590027,45.220001},
			new NSArray(2) {28.219971,47.849998},
			new NSArray(2) {18.080017,76.775002}
		}
		});
	}

	public static void rocket_used_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0.46499634,-4.6900024},
			new NSArray(2) {35.964996,-8.6900024},
			new NSArray(2) {48.464996,-0.69000244},
			new NSArray(2) {33.964996,6.8099976},
			new NSArray(2) {1.4649963,3.8099976}
		}
		});
	}

	public static void moving_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-119.91501,7.4400024},
			new NSArray(2) {-119.91501,-7.4450073},
			new NSArray(2) {119.91498,-7.4450073},
			new NSArray(2) {119.91498,7.4400024}
		}
		});
	}

	public static void golden_nail(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-5.5349731,-22.655029},
			new NSArray(2) {5.7849731,-22.784973},
			new NSArray(2) {0.125,22.769989}
		}
		});
	}

	public static void statue_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(8) {
			new NSArray(2) {-44.345001,-36.280029},
			new NSArray(2) {44.230011,-36.280029},
			new NSArray(2) {41.295013,-25.559998},
			new NSArray(2) {37.630005,-15.150024},
			new NSArray(2) {30.88501,-1.8499756},
			new NSArray(2) {-33.695007,2.2000122},
			new NSArray(2) {-38,-5.5},
			new NSArray(2) {-41.789993,-21.705017}
		},
		new NSArray(8) {
			new NSArray(2) {-33.695007,2.2000122},
			new NSArray(2) {30.88501,-1.8499756},
			new NSArray(2) {29.725006,15.88501},
			new NSArray(2) {17.5,32},
			new NSArray(2) {10.5,34.5},
			new NSArray(2) {4.6650085,36.125},
			new NSArray(2) {-24.25,22.63501},
			new NSArray(2) {-31.575012,13.190002}
		},
		new NSArray(5) {
			new NSArray(2) {-24.25,22.63501},
			new NSArray(2) {4.6650085,36.125},
			new NSArray(2) {-6.5,36.5},
			new NSArray(2) {-13.644989,34.200012},
			new NSArray(2) {-20,30}
		},
		new NSArray(4) {
			new NSArray(2) {17.5,32},
			new NSArray(2) {29.725006,15.88501},
			new NSArray(2) {26.5,24.5},
			new NSArray(2) {21.5,30}
		}
		});
	}

	public static void pyramid_brick_dark(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-46.265015,14.724976},
			new NSArray(2) {-46.265015,-14.76001},
			new NSArray(2) {46.22998,-14.76001},
			new NSArray(2) {46.22998,14.724976}
		}
		});
	}

	public static void fire_bowl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {18.48999,-5.7399902},
			new NSArray(2) {29.420013,-0.86999512},
			new NSArray(2) {37.190002,6.2399902},
			new NSArray(2) {40.744995,13.875},
			new NSArray(2) {-40.625,13.875},
			new NSArray(2) {-36.674988,5.7150269},
			new NSArray(2) {-29.040009,-0.86999512},
			new NSArray(2) {-18.769989,-5.875}
		},
		new NSArray(6) {
			new NSArray(2) {18.48999,-5.7399902},
			new NSArray(2) {-18.769989,-5.875},
			new NSArray(2) {-23.244995,-10.085022},
			new NSArray(2) {-25.355011,-14.299988},
			new NSArray(2) {25.339996,-14.299988},
			new NSArray(2) {22.970001,-9.8250122}
		}
		});
	}

	public static void rotate_drop(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {41.894989,-1.789978},
			new NSArray(2) {41.894989,1.4899902},
			new NSArray(2) {29.755005,11.125},
			new NSArray(2) {12.404999,20.184998},
			new NSArray(2) {0.45001221,21.919983},
			new NSArray(2) {0.26000977,-22.030029},
			new NSArray(2) {12.980011,-19.715027},
			new NSArray(2) {29.945007,-10.849976}
		},
		new NSArray(8) {
			new NSArray(2) {0.26000977,-22.030029},
			new NSArray(2) {0.45001221,21.919983},
			new NSArray(2) {-7.4500122,21.150024},
			new NSArray(2) {-16.515015,13.63501},
			new NSArray(2) {-20.559998,3.9949951},
			new NSArray(2) {-20.559998,-4.4899902},
			new NSArray(2) {-16.704987,-14.125},
			new NSArray(2) {-7.2600098,-21.26001}
		}
		});
	}

	public static void cage_fg(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(8) {
		new NSArray(4) {
			new NSArray(2) {-24.795013,-33.149994},
			new NSArray(2) {-18.295013,-34.649994},
			new NSArray(2) {-13.715376,4.2638359},
			new NSArray(2) {-24.5,6.5299988}
		},
		new NSArray(3) {
			new NSArray(2) {-12.119995,17.820007},
			new NSArray(2) {-0.89501953,40.654999},
			new NSArray(2) {-24.5,6.5299988}
		},
		new NSArray(4) {
			new NSArray(2) {17.705017,-33.649994},
			new NSArray(2) {23.705017,-33.149994},
			new NSArray(2) {21.429993,6.269989},
			new NSArray(2) {13.857717,-1.5300713}
		},
		new NSArray(3) {
			new NSArray(2) {11.539978,17.820007},
			new NSArray(2) {21.429993,6.269989},
			new NSArray(2) {-0.89501953,40.654999}
		},
		new NSArray(3) {
			new NSArray(2) {-12.119995,17.820007},
			new NSArray(2) {11.539978,17.820007},
			new NSArray(2) {-0.89501953,40.654999}
		},
		new NSArray(3) {
			new NSArray(2) {21.429993,6.269989},
			new NSArray(2) {12.557571,9.3244362},
			new NSArray(2) {13.857717,-1.5300713}
		},
		new NSArray(3) {
			new NSArray(2) {21.429993,6.269989},
			new NSArray(2) {11.539978,17.820007},
			new NSArray(2) {12.557571,9.3244324}
		},
		new NSArray(3) {
			new NSArray(2) {-24.5,6.5299988},
			new NSArray(2) {-13.715376,4.2638359},
			new NSArray(2) {-12.119995,17.820007}
		}
		});
	}

	public static void factory_barrel_still(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(12) {
		new NSArray(4) {
			new NSArray(2) {-30.98999,-13.01001},
			new NSArray(2) {-30.98999,-18.079987},
			new NSArray(2) {29.059998,-18.040009},
			new NSArray(2) {-28.130005,-13.01001}
		},
		new NSArray(4) {
			new NSArray(2) {31.065002,9.8399963},
			new NSArray(2) {31.065002,14.98999},
			new NSArray(2) {-28.130005,14.945007},
			new NSArray(2) {-30.905029,9.8399963}
		},
		new NSArray(4) {
			new NSArray(2) {-28.130005,-40.540009},
			new NSArray(2) {-30.98999,-45.529999},
			new NSArray(2) {31.015015,-45.529999},
			new NSArray(2) {31.015015,-40.459991}
		},
		new NSArray(4) {
			new NSArray(2) {29.059998,-18.040009},
			new NSArray(2) {31.02002,-18.040009},
			new NSArray(2) {30.984985,-12.984985},
			new NSArray(2) {-28.130005,-13.01001}
		},
		new NSArray(4) {
			new NSArray(2) {11.934998,45.390015},
			new NSArray(2) {11.934998,42.524994},
			new NSArray(2) {19.619995,42.524994},
			new NSArray(2) {19.619995,45.390015}
		},
		new NSArray(3) {
			new NSArray(2) {-30.98999,-45.529999},
			new NSArray(2) {-28.130005,-40.540009},
			new NSArray(2) {-30.98999,-40.540009}
		},
		new NSArray(4) {
			new NSArray(2) {-30.905029,37.459991},
			new NSArray(2) {-28.130005,37.459991},
			new NSArray(2) {11.934998,42.524994},
			new NSArray(2) {-30.905029,42.524994}
		},
		new NSArray(3) {
			new NSArray(2) {-30.905029,9.8399963},
			new NSArray(2) {-28.130005,14.945007},
			new NSArray(2) {-30.905029,14.945007}
		},
		new NSArray(6) {
			new NSArray(2) {-28.130005,14.945007},
			new NSArray(2) {29.02002,14.98999},
			new NSArray(2) {29.099976,37.459991},
			new NSArray(2) {19.619995,42.524994},
			new NSArray(2) {11.934998,42.524994},
			new NSArray(2) {-28.130005,37.459991}
		},
		new NSArray(4) {
			new NSArray(2) {29.099976,37.459991},
			new NSArray(2) {30.900024,37.459991},
			new NSArray(2) {30.900024,42.524994},
			new NSArray(2) {19.619995,42.524994}
		},
		new NSArray(4) {
			new NSArray(2) {-28.130005,-40.540009},
			new NSArray(2) {29.049988,-40.459991},
			new NSArray(2) {29.059998,-18.040009},
			new NSArray(2) {-28.130005,-18.079987}
		},
		new NSArray(4) {
			new NSArray(2) {-28.130005,9.8399963},
			new NSArray(2) {-28.130005,-13.01001},
			new NSArray(2) {29.099976,-12.984985},
			new NSArray(2) {29.099976,9.8399963}
		}
		});
	}

	public static void pile_of_coins_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-34.630001,-10.97998},
			new NSArray(2) {-39.630001,-27.47998},
			new NSArray(2) {-33.130001,-38.47998},
			new NSArray(2) {-22.630001,-40.47998},
			new NSArray(2) {37.370003,-39.97998},
			new NSArray(2) {31.370003,-3.9799805},
			new NSArray(2) {26.370003,4.5200195},
			new NSArray(2) {-28.630001,-1.4799805}
		},
		new NSArray(4) {
			new NSArray(2) {37.370003,-39.97998},
			new NSArray(2) {46.870003,-34.47998},
			new NSArray(2) {43.870003,-18.47998},
			new NSArray(2) {31.370003,-3.9799805}
		},
		new NSArray(8) {
			new NSArray(2) {-25.630001,10.52002},
			new NSArray(2) {-28.630001,-1.4799805},
			new NSArray(2) {26.370003,4.5200195},
			new NSArray(2) {23.870003,21.02002},
			new NSArray(2) {13.870003,37.52002},
			new NSArray(2) {2.8700027,48.02002},
			new NSArray(2) {-5.1299973,45.52002},
			new NSArray(2) {-16.130001,28.02002}
		}
		});
	}

	public static void factory_bit_cube(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-34.964996,34.954987},
			new NSArray(2) {-34.964996,-34.959991},
			new NSArray(2) {34.950012,-34.959991},
			new NSArray(2) {34.950012,34.954987}
		}
		});
	}

	public static void festival_star(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(7) {
			new NSArray(2) {17.38501,-8.7050171},
			new NSArray(2) {33.160004,7.8649902},
			new NSArray(2) {10.695007,11.684998},
			new NSArray(2) {-10.174988,11.530029},
			new NSArray(2) {-16.86499,-8.8649902},
			new NSArray(2) {-20.369995,-31.64502},
			new NSArray(2) {0.17999268,-21.130005}
		},
		new NSArray(3) {
			new NSArray(2) {-16.86499,-8.8649902},
			new NSArray(2) {-10.174988,11.530029},
			new NSArray(2) {-32.795013,7.3850098}
		},
		new NSArray(3) {
			new NSArray(2) {0.17999268,-21.130005},
			new NSArray(2) {20.734985,-30.849976},
			new NSArray(2) {17.38501,-8.7050171}
		},
		new NSArray(3) {
			new NSArray(2) {-10.174988,11.530029},
			new NSArray(2) {10.695007,11.684998},
			new NSArray(2) {0.17999268,31.284973}
		}
		});
	}

	public static void box(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(6) {
			new NSArray(2) {31.315002,-44.820007},
			new NSArray(2) {32.904999,-46.094971},
			new NSArray(2) {44.375,-46.094971},
			new NSArray(2) {46.290009,-43.705017},
			new NSArray(2) {46.290009,-31.914978},
			new NSArray(2) {45.334991,-30.164978}
		},
		new NSArray(6) {
			new NSArray(2) {-46.115005,43.26001},
			new NSArray(2) {-46.115005,31.945007},
			new NSArray(2) {-45.160004,30.094971},
			new NSArray(2) {-30.980011,45.01001},
			new NSArray(2) {-32.415009,46.125},
			new NSArray(2) {-43.25,46.125}
		},
		new NSArray(6) {
			new NSArray(2) {-46.115005,-44.344971},
			new NSArray(2) {-43.725006,-46.094971},
			new NSArray(2) {-32.095001,-46.094971},
			new NSArray(2) {-30.820007,-44.820007},
			new NSArray(2) {-45.160004,-30.640015},
			new NSArray(2) {-46.115005,-32.39502}
		},
		new NSArray(6) {
			new NSArray(2) {32.589996,46.125},
			new NSArray(2) {31.315002,45.01001},
			new NSArray(2) {45.334991,30.51001},
			new NSArray(2) {46.130005,32.585022},
			new NSArray(2) {46.130005,43.414978},
			new NSArray(2) {44.695007,46.125}
		},
		new NSArray(8) {
			new NSArray(2) {-30.820007,-44.820007},
			new NSArray(2) {31.315002,-44.820007},
			new NSArray(2) {45.334991,-30.164978},
			new NSArray(2) {45.334991,30.51001},
			new NSArray(2) {31.315002,45.01001},
			new NSArray(2) {-30.980011,45.01001},
			new NSArray(2) {-45.160004,30.094971},
			new NSArray(2) {-45.160004,-30.640015}
		}
		});
	}

	public static void factory_bit_nail(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-6.9550171,-24.179993},
			new NSArray(2) {7.2650146,-24.179993},
			new NSArray(2) {0.1550293,22.824997}
		}
		});
	}

	public static void rocket_used_2(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {34.464996,-7.6900024},
			new NSArray(2) {47.964996,-0.19000244},
			new NSArray(2) {34.964996,7.8099976},
			new NSArray(2) {0.46499634,3.8099976},
			new NSArray(2) {0.46499634,-5.1900024}
		}
		});
	}

	public static void factory_bit_fat(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-44.984985,12.48999},
			new NSArray(2) {-44.984985,-12.484985},
			new NSArray(2) {44.98999,-12.484985},
			new NSArray(2) {44.98999,12.48999}
		}
		});
	}

	public static void festival_cone(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {13.070007,-23.264999},
			new NSArray(2) {13.265015,-8.4099998},
			new NSArray(2) {6.0700073,12.424999},
			new NSArray(2) {-5.8250122,12.424999},
			new NSArray(2) {-13.405029,-8.3849983},
			new NSArray(2) {-12.820007,-23.264999},
			new NSArray(2) {-4.625,-41.160004},
			new NSArray(2) {5.3850098,-41.160004}
		},
		new NSArray(8) {
			new NSArray(2) {-5.8250122,12.424999},
			new NSArray(2) {6.0700073,12.424999},
			new NSArray(2) {7.1300049,34.395},
			new NSArray(2) {5.5499878,38.605},
			new NSArray(2) {1.8649902,40.845001},
			new NSArray(2) {-2.2150269,40.845001},
			new NSArray(2) {-6.164978,38.605},
			new NSArray(2) {-8.2700195,34.580002}
		}
		});
	}

	public static void wheel_bit(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(6) {
			new NSArray(2) {-11.184998,3.5200195},
			new NSArray(2) {-0.67498779,-1.9099731},
			new NSArray(2) {8.4400024,-2.789978},
			new NSArray(2) {3.1849976,4.2199707},
			new NSArray(2) {-3.2999878,8.2550049},
			new NSArray(2) {-9.7850037,9.1300049}
		},
		new NSArray(4) {
			new NSArray(2) {5.1099854,-9.4450073},
			new NSArray(2) {10.369995,-8.5700073},
			new NSArray(2) {8.4400024,-2.789978},
			new NSArray(2) {-0.67498779,-1.9099731}
		}
		});
	}

	public static void frozen_statue_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(8) {
			new NSArray(2) {50.494995,-36.700012},
			new NSArray(2) {50.994995,-23.700012},
			new NSArray(2) {40.994995,-7.7000122},
			new NSArray(2) {26.494995,3.2999878},
			new NSArray(2) {-24.505005,2.7999878},
			new NSArray(2) {-42.505005,-9.2000122},
			new NSArray(2) {-48.505005,-47.700012},
			new NSArray(2) {43.494995,-48.200012}
		},
		new NSArray(4) {
			new NSArray(2) {-48.505005,-47.700012},
			new NSArray(2) {-42.505005,-9.2000122},
			new NSArray(2) {-51.505005,-24.700012},
			new NSArray(2) {-51.005005,-40.700012}
		},
		new NSArray(8) {
			new NSArray(2) {-29.505005,31.799988},
			new NSArray(2) {-34.005005,15.299988},
			new NSArray(2) {-24.505005,2.7999878},
			new NSArray(2) {26.494995,3.2999878},
			new NSArray(2) {22.494995,41.299988},
			new NSArray(2) {5.4949951,46.799988},
			new NSArray(2) {-8.0050049,47.299988},
			new NSArray(2) {-22.005005,41.799988}
		},
		new NSArray(4) {
			new NSArray(2) {26.494995,3.2999878},
			new NSArray(2) {32.494995,14.799988},
			new NSArray(2) {31.494995,28.799988},
			new NSArray(2) {22.494995,41.299988}
		}
		});
	}

	public static void factory_bit_nut(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-10.924988,-17.429993},
			new NSArray(2) {10.914978,-17.429993},
			new NSArray(2) {10.929993,17.440002},
			new NSArray(2) {-10.914978,17.440002}
		}
		});
	}

	public static void pinky_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(6) {
			new NSArray(2) {-4.0799866,-4.125},
			new NSArray(2) {6.8800049,-17.190002},
			new NSArray(2) {13.415009,-11.125},
			new NSArray(2) {11.079987,1.7050171},
			new NSArray(2) {-0.11499023,16.164978},
			new NSArray(2) {-12.244995,7.7700195}
		},
		new NSArray(4) {
			new NSArray(2) {-10.380005,-16.719971},
			new NSArray(2) {6.8800049,-17.190002},
			new NSArray(2) {-4.0799866,-4.125},
			new NSArray(2) {-13.179993,-11.125}
		},
		new NSArray(3) {
			new NSArray(2) {-12.01001,3.1049805},
			new NSArray(2) {-4.0799866,-4.125},
			new NSArray(2) {-12.244995,7.7700195}
		},
		new NSArray(3) {
			new NSArray(2) {11.079987,1.7050171},
			new NSArray(2) {12.714996,9.1699829},
			new NSArray(2) {-0.11499023,16.164978}
		}
		});
	}

	public static void rope_bridge_base(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {25,7},
			new NSArray(2) {25,12.5},
			new NSArray(2) {-25,12.5},
			new NSArray(2) {-18.200012,-4.5},
			new NSArray(2) {-12.25,-9.5},
			new NSArray(2) {-4,-12.25},
			new NSArray(2) {18.200012,-4.5},
			new NSArray(2) {22.25,0.5}
		},
		new NSArray(4) {
			new NSArray(2) {-25,7},
			new NSArray(2) {-22.25,0.5},
			new NSArray(2) {-18.200012,-4.5},
			new NSArray(2) {-25,12.5}
		},
		new NSArray(4) {
			new NSArray(2) {12.25,-9.5},
			new NSArray(2) {18.200012,-4.5},
			new NSArray(2) {-4,-12.25},
			new NSArray(2) {4,-12.25}
		}
		});
	}

	public static void spring_board(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-29.830017,7.3299866},
			new NSArray(2) {-29.830017,-7.2999878},
			new NSArray(2) {29.840027,-7.2999878},
			new NSArray(2) {29.840027,7.3299866}
		}
		});
	}

	public static void flipper_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(8) {
			new NSArray(2) {84,-16.5},
			new NSArray(2) {88.549988,-5},
			new NSArray(2) {88.5,5.5},
			new NSArray(2) {84,17},
			new NSArray(2) {62.5,30.950001},
			new NSArray(2) {49,31},
			new NSArray(2) {62.5,-30.5},
			new NSArray(2) {76,-25}
		},
		new NSArray(3) {
			new NSArray(2) {62.5,30.950001},
			new NSArray(2) {84,17},
			new NSArray(2) {76,25.5}
		},
		new NSArray(8) {
			new NSArray(2) {-89.005005,0.025001526},
			new NSArray(2) {-86,-11},
			new NSArray(2) {-79.889999,-15.875},
			new NSArray(2) {-69,-18.5},
			new NSArray(2) {49,31},
			new NSArray(2) {-69,19},
			new NSArray(2) {-80.5,16},
			new NSArray(2) {-86,11}
		},
		new NSArray(4) {
			new NSArray(2) {49,-30.550003},
			new NSArray(2) {62.5,-30.5},
			new NSArray(2) {49,31},
			new NSArray(2) {-69,-18.5}
		}
		});
	}

	public static void cloud_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,5},
			new NSArray(2) {-45,-5},
			new NSArray(2) {45,-5},
			new NSArray(2) {45,5}
		}
		});
	}

	public static void rope_bridge_cracked(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {25,7},
			new NSArray(2) {25,12.5},
			new NSArray(2) {-25,12.5},
			new NSArray(2) {-18.200012,-4.5},
			new NSArray(2) {-12.25,-9.5},
			new NSArray(2) {-4,-12.25},
			new NSArray(2) {18.200012,-4.5},
			new NSArray(2) {22.25,0.5}
		},
		new NSArray(4) {
			new NSArray(2) {-25,7},
			new NSArray(2) {-22.25,0.5},
			new NSArray(2) {-18.200012,-4.5},
			new NSArray(2) {-25,12.5}
		},
		new NSArray(4) {
			new NSArray(2) {12.25,-9.5},
			new NSArray(2) {18.200012,-4.5},
			new NSArray(2) {-4,-12.25},
			new NSArray(2) {4,-12.25}
		}
		});
	}

	public static void cloud_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {54.555,33.855011},
			new NSArray(2) {57.5,60},
			new NSArray(2) {47.5,60},
			new NSArray(2) {44.805,36.079987},
			new NSArray(2) {45.864998,9.019989}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-57.5},
			new NSArray(2) {-33.855,-54.554993},
			new NSArray(2) {-9.0200005,-45.86499},
			new NSArray(2) {-36.080002,-44.804993},
			new NSArray(2) {-60,-47.5}
		},
		new NSArray(4) {
			new NSArray(2) {-36.080002,-44.804993},
			new NSArray(2) {-9.0200005,-45.86499},
			new NSArray(2) {13.260002,-31.86499},
			new NSArray(2) {-13.355,-36.855011}
		},
		new NSArray(4) {
			new NSArray(2) {-13.355,-36.855011},
			new NSArray(2) {13.260002,-31.86499},
			new NSArray(2) {31.864998,-13.26001},
			new NSArray(2) {7.0250015,-24.045013}
		},
		new NSArray(4) {
			new NSArray(2) {31.864998,-13.26001},
			new NSArray(2) {45.864998,9.019989},
			new NSArray(2) {36.855003,13.355011},
			new NSArray(2) {24.044998,-7.0249939}
		},
		new NSArray(3) {
			new NSArray(2) {7.0250015,-24.045013},
			new NSArray(2) {31.864998,-13.26001},
			new NSArray(2) {24.044998,-7.0249939}
		},
		new NSArray(3) {
			new NSArray(2) {36.855003,13.355011},
			new NSArray(2) {45.864998,9.019989},
			new NSArray(2) {44.805,36.079987}
		}
		});
	}

	public static void boost_tunnel_fg(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {20.320007,-54.994995},
			new NSArray(2) {21.244995,-52.755005},
			new NSArray(2) {-20.610001,-53.619995},
			new NSArray(2) {-19.044998,-55.915009}
		}
		});
	}

	public static void water_1(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-63.710022,-7.6750031},
			new NSArray(2) {63.869995,-7.8500061},
			new NSArray(2) {63.695007,4.0699997},
			new NSArray(2) {-63.710022,4.0699997}
		}
		});
	}

	public static void flipper_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(8) {
			new NSArray(2) {78.710022,16.74},
			new NSArray(2) {68.5,19},
			new NSArray(2) {-51.369995,-30.169998},
			new NSArray(2) {68.5,-18.5},
			new NSArray(2) {78.070007,-16.34},
			new NSArray(2) {85.705017,-10.404999},
			new NSArray(2) {88.25,0.24499893},
			new NSArray(2) {85.5,11}
		},
		new NSArray(8) {
			new NSArray(2) {-74.5,-26.5},
			new NSArray(2) {-63,-30.550003},
			new NSArray(2) {-51.369995,-30.169998},
			new NSArray(2) {-62.904999,30.469999},
			new NSArray(2) {-75,26.5},
			new NSArray(2) {-83.5,18.5},
			new NSArray(2) {-88.524994,-6.4249992},
			new NSArray(2) {-84,-18}
		},
		new NSArray(3) {
			new NSArray(2) {-88.524994,-6.4249992},
			new NSArray(2) {-83.5,18.5},
			new NSArray(2) {-88.5,8}
		},
		new NSArray(4) {
			new NSArray(2) {-51.369995,-30.169998},
			new NSArray(2) {68.5,19},
			new NSArray(2) {-51.795013,30.264999},
			new NSArray(2) {-62.904999,30.469999}
		}
		});
	}

	public static void trampoline_layer_2(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-88.584999,-10.039993},
			new NSArray(2) {88.764999,-10.039993},
			new NSArray(2) {88.589996,-4.6100006},
			new NSArray(2) {-88.584999,-4.6100006}
		}
		});
	}

	public static void trampoline_layer_3(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {108.03999,-0.35499573},
			new NSArray(2) {111.02,10.335007},
			new NSArray(2) {99.104996,5.6049957},
			new NSArray(2) {75.369995,-20.464996},
			new NSArray(2) {76.869995,-26.964996}
		},
		new NSArray(5) {
			new NSArray(2) {-108.13,0.035003662},
			new NSArray(2) {-76.130005,-28.464996},
			new NSArray(2) {-76.130005,-20.464996},
			new NSArray(2) {-100.13,5.5350037},
			new NSArray(2) {-110.13,9.0350037}
		},
		new NSArray(4) {
			new NSArray(2) {-76.130005,-28.464996},
			new NSArray(2) {-0.62999725,-40.964996},
			new NSArray(2) {-1.1299973,-35.964996},
			new NSArray(2) {-76.130005,-20.464996}
		},
		new NSArray(4) {
			new NSArray(2) {-1.1299973,-35.964996},
			new NSArray(2) {-0.62999725,-40.964996},
			new NSArray(2) {76.869995,-26.964996},
			new NSArray(2) {75.369995,-20.464996}
		}
		});
	}

	public static void boost_tunnel_fg_top(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-18.904999,50.269989},
			new NSArray(2) {22.345001,49.515015},
			new NSArray(2) {20.860001,55.024994},
			new NSArray(2) {-19.639999,55.875}
		}
		});
	}

	public static void boost_tunnel_bg(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {7,-48.5},
			new NSArray(2) {7.0200005,48.470001},
			new NSArray(2) {-1.5,48.5},
			new NSArray(2) {-1.5,-48.5}
		}
		});
	}
	public static void ice_cube_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,30},
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30}
		}
		});
	}

	public static void ice_curve_eighth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {0.97998047,-7.7150269},
			new NSArray(2) {10.715027,-1.2150269},
			new NSArray(2) {0.10498047,9.3950195},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,-10}
		},
		new NSArray(3) {
			new NSArray(2) {-10.5,-10},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,5}
		}
		});
	}

	public static void ice_curve_eighth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-4.2800293,3.9249878},
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {1.460022,-9.9349976},
			new NSArray(2) {20.924988,3.0750122},
			new NSArray(2) {10.320007,13.679993}
		},
		new NSArray(3) {
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {-4.2800293,3.9249878},
			new NSArray(2) {-21.5,0.5}
		}
		});
	}

	public static void ice_curve_eighth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {24.169983,-2.7750244},
			new NSArray(2) {42.35498,12.14502},
			new NSArray(2) {31.744995,22.755005},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {3.4199829,-13.86499}
		},
		new NSArray(5) {
			new NSArray(2) {-42.5,-8},
			new NSArray(2) {-42.5,-23},
			new NSArray(2) {-19.090027,-20.695007},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-22.015015,-5.9799805}
		},
		new NSArray(3) {
			new NSArray(2) {-22.015015,-5.9799805},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-2.3200073,-0.0050048828}
		},
		new NSArray(3) {
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {-2.3200073,-0.0050048828}
		}
		});
	}

	public static void ice_curve_eighth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(5) {
			new NSArray(2) {69.27002,15.649994},
			new NSArray(2) {84.705017,29.794998},
			new NSArray(2) {74.099976,40.399994},
			new NSArray(2) {59.625,27.139999},
			new NSArray(2) {52.659973,2.9049988}
		},
		new NSArray(5) {
			new NSArray(2) {-85,-40.5},
			new NSArray(2) {-64.084991,-39.584991},
			new NSArray(2) {-43.325012,-36.855011},
			new NSArray(2) {-65.390015,-24.644989},
			new NSArray(2) {-85,-25.5}
		},
		new NSArray(4) {
			new NSArray(2) {-65.390015,-24.644989},
			new NSArray(2) {-43.325012,-36.855011},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-45.929993,-22.079987}
		},
		new NSArray(4) {
			new NSArray(2) {52.659973,2.9049988},
			new NSArray(2) {59.625,27.139999},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {35,-8.3450012}
		},
		new NSArray(4) {
			new NSArray(2) {-45.929993,-22.079987},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {-26.765015,-17.835007}
		},
		new NSArray(3) {
			new NSArray(2) {-26.765015,-17.835007},
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {-8.0449829,-11.929993}
		},
		new NSArray(5) {
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {16.429993,-18.014999},
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {10.090027,-4.4199982},
			new NSArray(2) {-8.0449829,-11.929993}
		},
		new NSArray(3) {
			new NSArray(2) {10.090027,-4.4199982},
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {27.5,4.6450043}
		},
		new NSArray(3) {
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {27.5,4.6450043}
		}
		});
	}

	public static void ice_curve_fourth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(4) {
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {15,15},
			new NSArray(2) {0,15},
			new NSArray(2) {-4.3950195,4.394989}
		},
		new NSArray(4) {
			new NSArray(2) {-15,0},
			new NSArray(2) {-15,-15},
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {-4.3950195,4.394989}
		}
		});
	}

	public static void ice_curve_fourth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(5) {
			new NSArray(2) {25.434998,7.039978},
			new NSArray(2) {30,30},
			new NSArray(2) {15,30},
			new NSArray(2) {8.9699707,7.5},
			new NSArray(2) {12.424988,-12.424988}
		},
		new NSArray(5) {
			new NSArray(2) {-30,-15},
			new NSArray(2) {-30,-30},
			new NSArray(2) {-7.039978,-25.434998},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {-7.5,-8.9699707}
		},
		new NSArray(3) {
			new NSArray(2) {-7.5,-8.9699707},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {8.9699707,7.5}
		}
		});
	}

	public static void ice_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {57.695007,36.590027},
			new NSArray(2) {60,60},
			new NSArray(2) {45,60},
			new NSArray(2) {42.36499,36.63501},
			new NSArray(2) {50.86499,14.080017}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-45},
			new NSArray(2) {-60,-60},
			new NSArray(2) {-36.590027,-57.695007},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {-36.63501,-42.36499}
		},
		new NSArray(4) {
			new NSArray(2) {34.599976,14.440002},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {50.86499,14.080017},
			new NSArray(2) {42.36499,36.63501}
		},
		new NSArray(4) {
			new NSArray(2) {-36.63501,-42.36499},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {6.6699829,-39.775024},
			new NSArray(2) {-14.440002,-34.599976}
		},
		new NSArray(4) {
			new NSArray(2) {-14.440002,-34.599976},
			new NSArray(2) {6.6699829,-39.775024},
			new NSArray(2) {24.85498,-24.85498},
			new NSArray(2) {5.4650269,-22.090027}
		},
		new NSArray(4) {
			new NSArray(2) {5.4650269,-22.090027},
			new NSArray(2) {24.85498,-24.85498},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {22.090027,-5.4650269}
		},
		new NSArray(3) {
			new NSArray(2) {22.090027,-5.4650269},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {34.599976,14.440002}
		}
		});
	}

	public static void ice_curve_fourth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(15) {
		new NSArray(5) {
			new NSArray(2) {118.845,96.475006},
			new NSArray(2) {120,120},
			new NSArray(2) {105,120},
			new NSArray(2) {103.76501,96.480011},
			new NSArray(2) {115.39001,73.179993}
		},
		new NSArray(5) {
			new NSArray(2) {-120,-105},
			new NSArray(2) {-120,-120},
			new NSArray(2) {-96.475006,-118.84497},
			new NSArray(2) {-73.179993,-115.39001},
			new NSArray(2) {-96.480011,-103.76501}
		},
		new NSArray(4) {
			new NSArray(2) {109.66501,50.329987},
			new NSArray(2) {115.39001,73.179993},
			new NSArray(2) {103.76501,96.480011},
			new NSArray(2) {100.08499,73.220001}
		},
		new NSArray(4) {
			new NSArray(2) {-96.480011,-103.76501},
			new NSArray(2) {-73.179993,-115.39001},
			new NSArray(2) {-50.329987,-109.66498},
			new NSArray(2) {-73.220001,-100.08502}
		},
		new NSArray(4) {
			new NSArray(2) {-73.220001,-100.08502},
			new NSArray(2) {-50.329987,-109.66498},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-50.470001,-93.98999}
		},
		new NSArray(4) {
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {109.66501,50.329987},
			new NSArray(2) {100.08499,73.220001},
			new NSArray(2) {93.98999,50.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-50.470001,-93.98999},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-6.8649902,-91.659973},
			new NSArray(2) {-28.484985,-85.549988}
		},
		new NSArray(4) {
			new NSArray(2) {-28.484985,-85.549988},
			new NSArray(2) {-6.8649902,-91.659973},
			new NSArray(2) {13.334991,-79.554993},
			new NSArray(2) {-7.5,-74.85498}
		},
		new NSArray(4) {
			new NSArray(2) {-7.5,-74.85498},
			new NSArray(2) {13.334991,-79.554993},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {12.25,-62.030029}
		},
		new NSArray(5) {
			new NSArray(2) {30.554993,-47.210022},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {49.704987,-49.705017},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {47.209991,-30.554993}
		},
		new NSArray(3) {
			new NSArray(2) {12.25,-62.030029},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {30.554993,-47.210022}
		},
		new NSArray(4) {
			new NSArray(2) {47.209991,-30.554993},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {62.029999,-12.25}
		},
		new NSArray(4) {
			new NSArray(2) {62.029999,-12.25},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {74.855011,7.5}
		},
		new NSArray(4) {
			new NSArray(2) {74.855011,7.5},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {85.549988,28.484985}
		},
		new NSArray(3) {
			new NSArray(2) {85.549988,28.484985},
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {93.98999,50.470001}
		}
		});
	}

	public static void ice_curve_sixteenth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.65002441,-7.4249878},
			new NSArray(2) {4.9799805,-5.7150269},
			new NSArray(2) {-0.76000977,8.1400146},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,-8}
		},
		new NSArray(3) {
			new NSArray(2) {-6.5,-8},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,7}
		}
		});
	}

	public static void ice_curve_sixteenth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.29498291,-8.3449707},
			new NSArray(2) {10.960022,-4.9349976},
			new NSArray(2) {5.2199707,8.9249878},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-12,-9.5},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,5.5}
		}
		});
	}

	public static void ice_curve_sixteenth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {7.5599976,-7.4099731},
			new NSArray(2) {22.419983,-2.3649902},
			new NSArray(2) {16.679993,11.48999},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-7.835022,-10.474976}
		},
		new NSArray(4) {
			new NSArray(2) {-23.5,-11.5},
			new NSArray(2) {-7.835022,-10.474976},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-23.5,3.5}
		}
		});
	}

	public static void ice_curve_sixteenth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(5) {
			new NSArray(2) {30.64502,-3.7650146},
			new NSArray(2) {45.344971,1.7700195},
			new NSArray(2) {39.60498,15.625},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {15.61499,-8.3200073}
		},
		new NSArray(5) {
			new NSArray(2) {-46.5,-16.5},
			new NSArray(2) {-30.804993,-15.984985},
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {-28.844971,-0.80499268},
			new NSArray(2) {-46.5,-1.5}
		},
		new NSArray(4) {
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {-11.299988,1.2700195},
			new NSArray(2) {-28.844971,-0.80499268}
		},
		new NSArray(4) {
			new NSArray(2) {15.61499,-8.3200073},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {0.32000732,-11.890015}
		},
		new NSArray(3) {
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {-11.299988,1.2700195}
		}
		});
	}

	public static void ice_flat_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-7.5,7.5},
			new NSArray(2) {-7.5,-7.5},
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5}
		}
		});
	}

	public static void ice_flat_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,7.5},
			new NSArray(2) {-15,-7.5},
			new NSArray(2) {15,-7.5},
			new NSArray(2) {15,7.5}
		}
		});
	}

	public static void ice_flat_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,7.5},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void ice_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,7.5},
			new NSArray(2) {-45,-7.5},
			new NSArray(2) {45,-7.5},
			new NSArray(2) {45,7.5}
		}
		});
	}

	public static void ice_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,7.5},
			new NSArray(2) {-60,-7.5},
			new NSArray(2) {60,-7.5},
			new NSArray(2) {60,7.5}
		}
		});
	}

	public static void ice_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-120,7.5},
			new NSArray(2) {-120,-7.5},
			new NSArray(2) {120,-7.5},
			new NSArray(2) {120,7.5}
		}
		});
	}

	public static void ice_flat_xxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-240,7.5},
			new NSArray(2) {-240,-7.5},
			new NSArray(2) {240,-7.5},
			new NSArray(2) {240,7.5}
		}
		});
	}

	public static void ice_flat_xxxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-480,7.5},
			new NSArray(2) {-480,-7.5},
			new NSArray(2) {480,-7.5},
			new NSArray(2) {480,7.5}
		}
		});
	}

	public static void plastic_cube_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,30},
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30}
		}
		});
	}

	public static void plastic_curve_eighth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {0.97998047,-7.7150269},
			new NSArray(2) {10.715027,-1.2150269},
			new NSArray(2) {0.10498047,9.3950195},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,-10}
		},
		new NSArray(3) {
			new NSArray(2) {-10.5,-10},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,5}
		}
		});
	}

	public static void plastic_curve_eighth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-4.2800293,3.9249992},
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {1.460022,-9.9350014},
			new NSArray(2) {20.924988,3.0750008},
			new NSArray(2) {10.320007,13.68}
		},
		new NSArray(3) {
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {-4.2800293,3.9249992},
			new NSArray(2) {-21.5,0.5}
		}
		});
	}

	public static void plastic_curve_eighth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {24.169983,-2.7750244},
			new NSArray(2) {42.35498,12.14502},
			new NSArray(2) {31.744995,22.755005},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {3.4199829,-13.86499}
		},
		new NSArray(5) {
			new NSArray(2) {-42.5,-8},
			new NSArray(2) {-42.5,-23},
			new NSArray(2) {-19.090027,-20.695007},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-22.015015,-5.9799805}
		},
		new NSArray(3) {
			new NSArray(2) {-22.015015,-5.9799805},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-2.3200073,-0.0050048828}
		},
		new NSArray(3) {
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {-2.3200073,-0.0050048828}
		}
		});
	}

	public static void plastic_curve_eighth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(5) {
			new NSArray(2) {69.27002,15.649994},
			new NSArray(2) {84.705017,29.794998},
			new NSArray(2) {74.099976,40.400002},
			new NSArray(2) {59.625,27.139999},
			new NSArray(2) {52.659973,2.9049988}
		},
		new NSArray(5) {
			new NSArray(2) {-85,-40.5},
			new NSArray(2) {-64.084991,-39.585007},
			new NSArray(2) {-43.325012,-36.854996},
			new NSArray(2) {-65.390015,-24.645004},
			new NSArray(2) {-85,-25.5}
		},
		new NSArray(4) {
			new NSArray(2) {-65.390015,-24.645004},
			new NSArray(2) {-43.325012,-36.854996},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-45.929993,-22.080002}
		},
		new NSArray(4) {
			new NSArray(2) {52.659973,2.9049988},
			new NSArray(2) {59.625,27.139999},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {35,-8.3450012}
		},
		new NSArray(4) {
			new NSArray(2) {-45.929993,-22.080002},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {-26.765015,-17.835007}
		},
		new NSArray(3) {
			new NSArray(2) {-26.765015,-17.835007},
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {-8.0449829,-11.929993}
		},
		new NSArray(5) {
			new NSArray(2) {-2.914978,-26.024994},
			new NSArray(2) {16.429993,-18.014999},
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {10.090027,-4.4199982},
			new NSArray(2) {-8.0449829,-11.929993}
		},
		new NSArray(3) {
			new NSArray(2) {10.090027,-4.4199982},
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {27.5,4.6450043}
		},
		new NSArray(3) {
			new NSArray(2) {35,-8.3450012},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {27.5,4.6450043}
		}
		});
	}

	public static void plastic_curve_fourth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(4) {
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {15,15},
			new NSArray(2) {0,15},
			new NSArray(2) {-4.3950195,4.394989}
		},
		new NSArray(4) {
			new NSArray(2) {-15,0},
			new NSArray(2) {-15,-15},
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {-4.3950195,4.394989}
		}
		});
	}

	public static void plastic_curve_fourth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(5) {
			new NSArray(2) {25.434998,7.039978},
			new NSArray(2) {30,30},
			new NSArray(2) {15,30},
			new NSArray(2) {8.9699707,7.5},
			new NSArray(2) {12.424988,-12.424988}
		},
		new NSArray(5) {
			new NSArray(2) {-30,-15},
			new NSArray(2) {-30,-30},
			new NSArray(2) {-7.039978,-25.434998},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {-7.5,-8.9699707}
		},
		new NSArray(3) {
			new NSArray(2) {-7.5,-8.9699707},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {8.9699707,7.5}
		}
		});
	}

	public static void plastic_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {57.695007,36.590027},
			new NSArray(2) {60,60},
			new NSArray(2) {45,60},
			new NSArray(2) {42.36499,36.63501},
			new NSArray(2) {50.86499,14.080017}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-45},
			new NSArray(2) {-60,-60},
			new NSArray(2) {-36.590027,-57.695007},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {-36.63501,-42.36499}
		},
		new NSArray(4) {
			new NSArray(2) {34.599976,14.440002},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {50.86499,14.080017},
			new NSArray(2) {42.36499,36.63501}
		},
		new NSArray(4) {
			new NSArray(2) {-36.63501,-42.36499},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {6.6699829,-39.775024},
			new NSArray(2) {-14.440002,-34.599976}
		},
		new NSArray(4) {
			new NSArray(2) {-14.440002,-34.599976},
			new NSArray(2) {6.6699829,-39.775024},
			new NSArray(2) {24.85498,-24.85498},
			new NSArray(2) {5.4650269,-22.090027}
		},
		new NSArray(4) {
			new NSArray(2) {5.4650269,-22.090027},
			new NSArray(2) {24.85498,-24.85498},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {22.090027,-5.4650269}
		},
		new NSArray(3) {
			new NSArray(2) {22.090027,-5.4650269},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {34.599976,14.440002}
		}
		});
	}

	public static void plastic_curve_fourth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(15) {
		new NSArray(5) {
			new NSArray(2) {118.845,96.475006},
			new NSArray(2) {120,120},
			new NSArray(2) {105,120},
			new NSArray(2) {103.76501,96.479996},
			new NSArray(2) {115.39001,73.179993}
		},
		new NSArray(5) {
			new NSArray(2) {-120,-105},
			new NSArray(2) {-120,-120},
			new NSArray(2) {-96.475006,-118.845},
			new NSArray(2) {-73.179993,-115.39001},
			new NSArray(2) {-96.480011,-103.76501}
		},
		new NSArray(4) {
			new NSArray(2) {109.66501,50.330002},
			new NSArray(2) {115.39001,73.179993},
			new NSArray(2) {103.76501,96.479996},
			new NSArray(2) {100.08499,73.220001}
		},
		new NSArray(4) {
			new NSArray(2) {-96.480011,-103.76501},
			new NSArray(2) {-73.179993,-115.39001},
			new NSArray(2) {-50.329987,-109.66501},
			new NSArray(2) {-73.220001,-100.08499}
		},
		new NSArray(4) {
			new NSArray(2) {-73.220001,-100.08499},
			new NSArray(2) {-50.329987,-109.66501},
			new NSArray(2) {-28.154999,-101.73001},
			new NSArray(2) {-50.470001,-93.98999}
		},
		new NSArray(4) {
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {109.66501,50.330002},
			new NSArray(2) {100.08499,73.220001},
			new NSArray(2) {93.98999,50.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-50.470001,-93.98999},
			new NSArray(2) {-28.154999,-101.73001},
			new NSArray(2) {-6.8649902,-91.660004},
			new NSArray(2) {-28.484985,-85.549988}
		},
		new NSArray(4) {
			new NSArray(2) {-28.484985,-85.549988},
			new NSArray(2) {-6.8649902,-91.660004},
			new NSArray(2) {13.334991,-79.554993},
			new NSArray(2) {-7.5,-74.855011}
		},
		new NSArray(4) {
			new NSArray(2) {-7.5,-74.855011},
			new NSArray(2) {13.334991,-79.554993},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {12.25,-62.029999}
		},
		new NSArray(5) {
			new NSArray(2) {30.554993,-47.209991},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {49.704987,-49.704987},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {47.209991,-30.554993}
		},
		new NSArray(3) {
			new NSArray(2) {12.25,-62.029999},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {30.554993,-47.209991}
		},
		new NSArray(4) {
			new NSArray(2) {47.209991,-30.554993},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {79.554993,-13.334991},
			new NSArray(2) {62.029999,-12.25}
		},
		new NSArray(4) {
			new NSArray(2) {62.029999,-12.25},
			new NSArray(2) {79.554993,-13.334991},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {74.855011,7.5}
		},
		new NSArray(4) {
			new NSArray(2) {74.855011,7.5},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {85.549988,28.485001}
		},
		new NSArray(3) {
			new NSArray(2) {85.549988,28.485001},
			new NSArray(2) {101.73001,28.154999},
			new NSArray(2) {93.98999,50.470001}
		}
		});
	}

	public static void plastic_curve_sixteenth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.65002441,-7.4249878},
			new NSArray(2) {4.9799805,-5.7150269},
			new NSArray(2) {-0.76000977,8.1400146},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,-8}
		},
		new NSArray(3) {
			new NSArray(2) {-6.5,-8},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,7}
		}
		});
	}

	public static void plastic_curve_sixteenth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.29498291,-8.3449707},
			new NSArray(2) {10.960022,-4.9349976},
			new NSArray(2) {5.2199707,8.9249878},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-12,-9.5},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,5.5}
		}
		});
	}

	public static void plastic_curve_sixteenth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {7.5599976,-7.4099731},
			new NSArray(2) {22.419983,-2.3649902},
			new NSArray(2) {16.679993,11.48999},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-7.835022,-10.474976}
		},
		new NSArray(4) {
			new NSArray(2) {-23.5,-11.5},
			new NSArray(2) {-7.835022,-10.474976},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-23.5,3.5}
		}
		});
	}

	public static void plastic_curve_sixteenth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(5) {
			new NSArray(2) {30.64502,-3.7650146},
			new NSArray(2) {45.344971,1.7700195},
			new NSArray(2) {39.60498,15.625},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {15.61499,-8.3200073}
		},
		new NSArray(5) {
			new NSArray(2) {-46.5,-16.5},
			new NSArray(2) {-30.804993,-15.984985},
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {-28.844971,-0.80499268},
			new NSArray(2) {-46.5,-1.5}
		},
		new NSArray(4) {
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {-11.299988,1.2700195},
			new NSArray(2) {-28.844971,-0.80499268}
		},
		new NSArray(4) {
			new NSArray(2) {15.61499,-8.3200073},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {0.32000732,-11.890015}
		},
		new NSArray(3) {
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {-11.299988,1.2700195}
		}
		});
	}

	public static void plastic_flat_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-7.5,7.5},
			new NSArray(2) {-7.5,-7.5},
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5}
		}
		});
	}

	public static void plastic_flat_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,7.5},
			new NSArray(2) {-15,-7.5},
			new NSArray(2) {15,-7.5},
			new NSArray(2) {15,7.5}
		}
		});
	}

	public static void plastic_flat_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,7.5},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void plastic_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,7.5},
			new NSArray(2) {-45,-7.5},
			new NSArray(2) {45,-7.5},
			new NSArray(2) {45,7.5}
		}
		});
	}

	public static void plastic_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,7.5},
			new NSArray(2) {-60,-7.5},
			new NSArray(2) {60,-7.5},
			new NSArray(2) {60,7.5}
		}
		});
	}

	public static void plastic_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-120,7.5},
			new NSArray(2) {-120,-7.5},
			new NSArray(2) {120,-7.5},
			new NSArray(2) {120,7.5}
		}
		});
	}

	public static void plastic_flat_xxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-240,7.5},
			new NSArray(2) {-240,-7.5},
			new NSArray(2) {240,-7.5},
			new NSArray(2) {240,7.5}
		}
		});
	}

	public static void plastic_flat_xxxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-480,7.5},
			new NSArray(2) {-480,-7.5},
			new NSArray(2) {480,-7.5},
			new NSArray(2) {480,7.5}
		}
		});
	}

	public static void rock_bump_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,3.5},
			new NSArray(2) {-5.3049927,1.3049927},
			new NSArray(2) {-7.5,-4},
			new NSArray(2) {7.5,-4},
			new NSArray(2) {5.3049927,1.3049927}
		}
		});
	}

	public static void rock_bump_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {-10.60498,2.605011},
			new NSArray(2) {-15,-8},
			new NSArray(2) {15,-8},
			new NSArray(2) {10.60498,2.605011},
			new NSArray(2) {0,7}
		}
		});
	}

	public static void rock_bump_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {11.47998,12.715027},
			new NSArray(2) {0,15},
			new NSArray(2) {-11.47998,12.715027},
			new NSArray(2) {-27.715027,-3.5200195},
			new NSArray(2) {-30,-15},
			new NSArray(2) {30,-15},
			new NSArray(2) {27.715027,-3.5200195},
			new NSArray(2) {21.215027,6.2150269}
		},
		new NSArray(3) {
			new NSArray(2) {-27.715027,-3.5200195},
			new NSArray(2) {-11.47998,12.715027},
			new NSArray(2) {-21.215027,6.2150269}
		}
		});
	}

	public static void rock_bump_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {11.64502,20.964996},
			new NSArray(2) {0,22.5},
			new NSArray(2) {-11.64502,20.964996},
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {43.465027,-10.855011},
			new NSArray(2) {38.969971,0},
			new NSArray(2) {31.820007,9.3200073},
			new NSArray(2) {22.5,16.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {-45,-22.5},
			new NSArray(2) {45,-22.5},
			new NSArray(2) {43.465027,-10.855011}
		},
		new NSArray(5) {
			new NSArray(2) {-38.969971,0},
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {-11.64502,20.964996},
			new NSArray(2) {-22.5,16.470001},
			new NSArray(2) {-31.820007,9.3200073}
		}
		});
	}

	public static void rock_cube_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,15},
			new NSArray(2) {-15,-15},
			new NSArray(2) {15,-15},
			new NSArray(2) {15,15}
		}
		});
	}

	public static void rock_cube_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,30},
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30}
		}
		});
	}

	public static void rock_cube_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,45},
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45}
		}
		});
	}

	public static void rock_cube_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,60},
			new NSArray(2) {-60,-60},
			new NSArray(2) {60,-60},
			new NSArray(2) {60,60}
		}
		});
	}

	public static void rock_curve_eighth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {0.97998047,-7.7150269},
			new NSArray(2) {10.715027,-1.2150269},
			new NSArray(2) {0.10498047,9.3950195},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,-10}
		},
		new NSArray(3) {
			new NSArray(2) {-10.5,-10},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,5}
		}
		});
	}

	public static void rock_curve_eighth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-4.2800293,3.9250002},
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {1.460022,-9.9349995},
			new NSArray(2) {20.924988,3.0749998},
			new NSArray(2) {10.320007,13.68}
		},
		new NSArray(3) {
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {-4.2800293,3.9250002},
			new NSArray(2) {-21.5,0.5}
		}
		});
	}

	public static void rock_curve_eighth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {24.169983,-2.7750244},
			new NSArray(2) {42.35498,12.14502},
			new NSArray(2) {31.744995,22.755005},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {3.4199829,-13.86499}
		},
		new NSArray(5) {
			new NSArray(2) {-42.5,-8},
			new NSArray(2) {-42.5,-23},
			new NSArray(2) {-19.090027,-20.695007},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-22.015015,-5.9799805}
		},
		new NSArray(3) {
			new NSArray(2) {-22.015015,-5.9799805},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-2.3200073,-0.0050048828}
		},
		new NSArray(3) {
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {-2.3200073,-0.0050048828}
		}
		});
	}

	public static void rock_curve_eighth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(5) {
			new NSArray(2) {69.269989,15.650024},
			new NSArray(2) {84.704987,29.794983},
			new NSArray(2) {74.100006,40.400024},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {52.660004,2.9050293}
		},
		new NSArray(5) {
			new NSArray(2) {-85,-40.5},
			new NSArray(2) {-64.084991,-39.585022},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-85,-25.5}
		},
		new NSArray(4) {
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-45.929993,-22.080017}
		},
		new NSArray(4) {
			new NSArray(2) {52.660004,2.9050293},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {35,-8.3449707}
		},
		new NSArray(4) {
			new NSArray(2) {-45.929993,-22.080017},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-26.765015,-17.835022}
		},
		new NSArray(3) {
			new NSArray(2) {-26.765015,-17.835022},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(5) {
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {16.429993,-18.015015},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(3) {
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {27.5,4.6450195}
		},
		new NSArray(3) {
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {27.5,4.6450195}
		}
		});
	}

	public static void rock_curve_fourth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(4) {
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {15,15},
			new NSArray(2) {0,15},
			new NSArray(2) {-4.3950195,4.394989}
		},
		new NSArray(4) {
			new NSArray(2) {-15,0},
			new NSArray(2) {-15,-15},
			new NSArray(2) {6.2150269,-6.2149963},
			new NSArray(2) {-4.3950195,4.394989}
		}
		});
	}

	public static void rock_curve_fourth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(5) {
			new NSArray(2) {25.434998,7.039978},
			new NSArray(2) {30,30},
			new NSArray(2) {15,30},
			new NSArray(2) {8.9699707,7.5},
			new NSArray(2) {12.424988,-12.424988}
		},
		new NSArray(5) {
			new NSArray(2) {-30,-15},
			new NSArray(2) {-30,-30},
			new NSArray(2) {-7.039978,-25.434998},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {-7.5,-8.9699707}
		},
		new NSArray(3) {
			new NSArray(2) {-7.5,-8.9699707},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {8.9699707,7.5}
		}
		});
	}

	public static void rock_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {57.695007,36.589996},
			new NSArray(2) {60,60},
			new NSArray(2) {45,60},
			new NSArray(2) {42.36499,36.634995},
			new NSArray(2) {50.86499,14.080002}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-45},
			new NSArray(2) {-60,-60},
			new NSArray(2) {-36.590027,-57.695007},
			new NSArray(2) {-14.080017,-50.865005},
			new NSArray(2) {-36.63501,-42.365005}
		},
		new NSArray(4) {
			new NSArray(2) {34.599976,14.440002},
			new NSArray(2) {39.775024,-6.6699982},
			new NSArray(2) {50.86499,14.080002},
			new NSArray(2) {42.36499,36.634995}
		},
		new NSArray(4) {
			new NSArray(2) {-36.63501,-42.365005},
			new NSArray(2) {-14.080017,-50.865005},
			new NSArray(2) {6.6699829,-39.774994},
			new NSArray(2) {-14.440002,-34.600006}
		},
		new NSArray(4) {
			new NSArray(2) {-14.440002,-34.600006},
			new NSArray(2) {6.6699829,-39.774994},
			new NSArray(2) {24.85498,-24.854996},
			new NSArray(2) {5.4650269,-22.089996}
		},
		new NSArray(4) {
			new NSArray(2) {5.4650269,-22.089996},
			new NSArray(2) {24.85498,-24.854996},
			new NSArray(2) {39.775024,-6.6699982},
			new NSArray(2) {22.090027,-5.4649963}
		},
		new NSArray(3) {
			new NSArray(2) {22.090027,-5.4649963},
			new NSArray(2) {39.775024,-6.6699982},
			new NSArray(2) {34.599976,14.440002}
		}
		});
	}

	public static void rock_curve_fourth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(15) {
		new NSArray(5) {
			new NSArray(2) {118.845,96.474976},
			new NSArray(2) {120,120},
			new NSArray(2) {105,120},
			new NSArray(2) {103.765,96.47998},
			new NSArray(2) {115.39,73.179993}
		},
		new NSArray(5) {
			new NSArray(2) {-120,-105},
			new NSArray(2) {-120,-120},
			new NSArray(2) {-96.474998,-118.84497},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-96.479996,-103.76501}
		},
		new NSArray(4) {
			new NSArray(2) {109.66499,50.330017},
			new NSArray(2) {115.39,73.179993},
			new NSArray(2) {103.765,96.47998},
			new NSArray(2) {100.08501,73.219971}
		},
		new NSArray(4) {
			new NSArray(2) {-96.479996,-103.76501},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-50.330002,-109.66498},
			new NSArray(2) {-73.220001,-100.08502}
		},
		new NSArray(4) {
			new NSArray(2) {-73.220001,-100.08502},
			new NSArray(2) {-50.330002,-109.66498},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-50.470001,-93.98999}
		},
		new NSArray(4) {
			new NSArray(2) {101.73,28.155029},
			new NSArray(2) {109.66499,50.330017},
			new NSArray(2) {100.08501,73.219971},
			new NSArray(2) {93.990005,50.469971}
		},
		new NSArray(4) {
			new NSArray(2) {-50.470001,-93.98999},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-6.8649979,-91.659973},
			new NSArray(2) {-28.485001,-85.549988}
		},
		new NSArray(4) {
			new NSArray(2) {-28.485001,-85.549988},
			new NSArray(2) {-6.8649979,-91.659973},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {-7.5,-74.85498}
		},
		new NSArray(4) {
			new NSArray(2) {-7.5,-74.85498},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {12.25,-62.030029}
		},
		new NSArray(5) {
			new NSArray(2) {30.554993,-47.210022},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {49.705002,-49.705017},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {47.210007,-30.554993}
		},
		new NSArray(3) {
			new NSArray(2) {12.25,-62.030029},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {30.554993,-47.210022}
		},
		new NSArray(4) {
			new NSArray(2) {47.210007,-30.554993},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {62.029999,-12.25}
		},
		new NSArray(4) {
			new NSArray(2) {62.029999,-12.25},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(4) {
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {101.73,28.155029},
			new NSArray(2) {85.550003,28.484985},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {85.550003,28.484985},
			new NSArray(2) {101.73,28.155029},
			new NSArray(2) {93.990005,50.469971}
		}
		});
	}

	public static void rock_curve_sixteenth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.65002441,-7.4249878},
			new NSArray(2) {4.9799805,-5.7150269},
			new NSArray(2) {-0.76000977,8.1400146},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,-8}
		},
		new NSArray(3) {
			new NSArray(2) {-6.5,-8},
			new NSArray(2) {-3.5750122,7.289978},
			new NSArray(2) {-6.5,7}
		}
		});
	}

	public static void rock_curve_sixteenth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.29499817,-8.3449707},
			new NSArray(2) {10.960007,-4.9349976},
			new NSArray(2) {5.2200012,8.9249878},
			new NSArray(2) {-3.2200012,6.3649902},
			new NSArray(2) {-12,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-12,-9.5},
			new NSArray(2) {-3.2200012,6.3649902},
			new NSArray(2) {-12,5.5}
		}
		});
	}

	public static void rock_curve_sixteenth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {7.5599976,-7.4099731},
			new NSArray(2) {22.419983,-2.3649902},
			new NSArray(2) {16.679993,11.48999},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-7.835022,-10.474976}
		},
		new NSArray(4) {
			new NSArray(2) {-23.5,-11.5},
			new NSArray(2) {-7.835022,-10.474976},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-23.5,3.5}
		}
		});
	}

	public static void rock_curve_sixteenth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(5) {
			new NSArray(2) {30.64502,-3.7650146},
			new NSArray(2) {45.344971,1.7700195},
			new NSArray(2) {39.60498,15.625},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {15.61499,-8.3200073}
		},
		new NSArray(5) {
			new NSArray(2) {-46.5,-16.5},
			new NSArray(2) {-30.804993,-15.984985},
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {-28.844971,-0.80499268},
			new NSArray(2) {-46.5,-1.5}
		},
		new NSArray(4) {
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {-11.299988,1.2700195},
			new NSArray(2) {-28.844971,-0.80499268}
		},
		new NSArray(4) {
			new NSArray(2) {15.61499,-8.3200073},
			new NSArray(2) {23.030029,9.5150146},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {0.32000732,-11.890015}
		},
		new NSArray(3) {
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {6.0250244,4.7150269},
			new NSArray(2) {-11.299988,1.2700195}
		}
		});
	}

	public static void rock_flat_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-7.5,7.5},
			new NSArray(2) {-7.5,-7.5},
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5}
		}
		});
	}

	public static void rock_flat_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,7.5},
			new NSArray(2) {-15,-7.5},
			new NSArray(2) {15,-7.5},
			new NSArray(2) {15,7.5}
		}
		});
	}

	public static void rock_flat_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,7.5},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void rock_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,7.5},
			new NSArray(2) {-45,-7.5},
			new NSArray(2) {45,-7.5},
			new NSArray(2) {45,7.5}
		}
		});
	}

	public static void rock_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,7.5},
			new NSArray(2) {-60,-7.5},
			new NSArray(2) {60,-7.5},
			new NSArray(2) {60,7.5}
		}
		});
	}

	public static void rock_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-120,7.5},
			new NSArray(2) {-120,-7.5},
			new NSArray(2) {120,-7.5},
			new NSArray(2) {120,7.5}
		}
		});
	}

	public static void rock_flat_xxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-240,7.5},
			new NSArray(2) {-240,-7.5},
			new NSArray(2) {240,-7.5},
			new NSArray(2) {240,7.5}
		}
		});
	}

	public static void rock_flat_xxxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-480,7.5},
			new NSArray(2) {-480,-7.5},
			new NSArray(2) {480,-7.5},
			new NSArray(2) {480,7.5}
		}
		});
	}

	public static void rock_hump_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,2.5},
			new NSArray(2) {-4.25,1.3600006},
			new NSArray(2) {-7.5,-2.5},
			new NSArray(2) {7.5,-2.5},
			new NSArray(2) {4.25,1.3600006}
		}
		});
	}

	public static void rock_hump_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,4},
			new NSArray(2) {-9.1550293,1.7150269},
			new NSArray(2) {-15,-4},
			new NSArray(2) {15,-4},
			new NSArray(2) {9.1550293,1.7150269}
		}
		});
	}

	public static void rock_hump_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(7) {
			new NSArray(2) {0,5},
			new NSArray(2) {-10.210022,4.0150146},
			new NSArray(2) {-20.039978,1.1049805},
			new NSArray(2) {-30,-5},
			new NSArray(2) {30,-5},
			new NSArray(2) {20.039978,1.1049805},
			new NSArray(2) {10.210022,4.0150146}
		}
		});
	}

	public static void rock_hump_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {0,6},
			new NSArray(2) {-12.125,5.2249756},
			new NSArray(2) {-24.054993,2.9050293},
			new NSArray(2) {-45,-6},
			new NSArray(2) {45,-6},
			new NSArray(2) {35.590027,-0.91998291},
			new NSArray(2) {24.054993,2.9050293},
			new NSArray(2) {12.125,5.2249756}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-6},
			new NSArray(2) {-24.054993,2.9050293},
			new NSArray(2) {-35.590027,-0.91998291}
		}
		});
	}

	public static void rock_pie_quarter_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5},
			new NSArray(2) {-3.1049805,3.1049805},
			new NSArray(2) {-7.5,-7.5}
		}
		});
	}

	public static void rock_pie_quarter_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(6) {
			new NSArray(2) {15,-15},
			new NSArray(2) {15,15},
			new NSArray(2) {3.5200195,12.715027},
			new NSArray(2) {-6.2150269,6.2150269},
			new NSArray(2) {-12.715027,-3.5200195},
			new NSArray(2) {-15,-15}
		}
		});
	}

	public static void rock_pie_quarter_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30},
			new NSArray(2) {18.294983,28.844971},
			new NSArray(2) {7.039978,25.434998},
			new NSArray(2) {-3.335022,19.890015},
			new NSArray(2) {-12.424988,12.424988},
			new NSArray(2) {-19.890015,3.335022},
			new NSArray(2) {-25.434998,-7.039978}
		},
		new NSArray(4) {
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {-25.434998,-7.039978},
			new NSArray(2) {-28.844971,-18.294983}
		}
		});
	}

	public static void rock_pie_quarter_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(7) {
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45},
			new NSArray(2) {33.255005,44.230011},
			new NSArray(2) {21.705017,41.934998},
			new NSArray(2) {10.559998,38.149994},
			new NSArray(2) {0,32.940002},
			new NSArray(2) {-9.789978,26.399994}
		},
		new NSArray(8) {
			new NSArray(2) {-18.640015,18.640015},
			new NSArray(2) {-26.400024,9.7900085},
			new NSArray(2) {-32.940002,0},
			new NSArray(2) {-38.150024,-10.559998},
			new NSArray(2) {-41.934998,-21.704987},
			new NSArray(2) {-44.22998,-33.255005},
			new NSArray(2) {45,-45},
			new NSArray(2) {-9.789978,26.399994}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {-44.22998,-33.255005}
		}
		});
	}

	public static void rock_pie_quarter_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-24.855011,24.85498},
			new NSArray(2) {-32.76001,16.125},
			new NSArray(2) {-39.774994,6.6699829},
			new NSArray(2) {-45.829987,-3.4299927},
			new NSArray(2) {-50.86499,-14.080017},
			new NSArray(2) {60,-60},
			new NSArray(2) {-6.6700134,39.775024},
			new NSArray(2) {-16.125,32.76001}
		},
		new NSArray(8) {
			new NSArray(2) {25.165009,54.835022},
			new NSArray(2) {14.079987,50.86499},
			new NSArray(2) {3.4299927,45.830017},
			new NSArray(2) {-6.6700134,39.775024},
			new NSArray(2) {60,-60},
			new NSArray(2) {60,60},
			new NSArray(2) {48.23999,59.419983},
			new NSArray(2) {36.590027,57.695007}
		},
		new NSArray(6) {
			new NSArray(2) {-60,-60},
			new NSArray(2) {60,-60},
			new NSArray(2) {-50.86499,-14.080017},
			new NSArray(2) {-54.834991,-25.164978},
			new NSArray(2) {-57.695007,-36.590027},
			new NSArray(2) {-59.420013,-48.23999}
		}
		});
	}

	public static void rock_pyramid_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-7.5,-4},
			new NSArray(2) {7.5,-4},
			new NSArray(2) {0,4}
		}
		});
	}

	public static void rock_pyramid_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-15,-8},
			new NSArray(2) {15,-8},
			new NSArray(2) {0,8}
		}
		});
	}

	public static void rock_pyramid_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-30,-15.5},
			new NSArray(2) {30,-15.5},
			new NSArray(2) {0,15.5}
		}
		});
	}

	public static void rock_pyramid_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-45,-23},
			new NSArray(2) {45,-23},
			new NSArray(2) {0,23}
		}
		});
	}

	public static void rock_pyramid_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-60,-30.5},
			new NSArray(2) {60,-30.5},
			new NSArray(2) {0,30.5}
		}
		});
	}

	public static void rock_ramp_xxs_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {3.1599731,-4.8250122}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {3.1599731,-4.8250122},
			new NSArray(2) {-7.2199707,-1.5499878}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {-14.974976,2.2349854},
			new NSArray(2) {-22.5,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {-7.2199707,-1.5499878},
			new NSArray(2) {-14.974976,2.2349854}
		}
		});
	}

	public static void rock_ramp_xs_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(8) {
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {20.5,-3.4699707},
			new NSArray(2) {10.825012,0.075012207},
			new NSArray(2) {0.93499756,2.9849854},
			new NSArray(2) {-9.1199951,5.2349854},
			new NSArray(2) {-19.304993,6.8250122},
			new NSArray(2) {-30,7.5}
		}
		});
	}

	public static void rock_ramp_s_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(4) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {0,-15},
			new NSArray(2) {-7.8499756,-5.3150024},
			new NSArray(2) {-21.97998,0.30999756}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {23.025024,-12.61499}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {-35,7.375},
			new NSArray(2) {-45.5,15}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {-21.97998,0.30999756},
			new NSArray(2) {-35,7.375}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {23.025024,-12.61499},
			new NSArray(2) {6.5050049,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {6.5050049,-9.5},
			new NSArray(2) {-7.8499756,-5.3150024}
		}
		});
	}

	public static void rock_ramp_m_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {27.679993,-26.584991},
			new NSArray(2) {12.049988,-21.475006}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {27.679993,-26.584991}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-38.700012,19.040009},
			new NSArray(2) {-45.5,30}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-28.330017,6.2749939},
			new NSArray(2) {-38.700012,19.040009}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-16.244995,-4.875},
			new NSArray(2) {-28.330017,6.2749939}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-2.6950073,-14.190002},
			new NSArray(2) {-16.244995,-4.875}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {12.049988,-21.475006},
			new NSArray(2) {-2.6950073,-14.190002}
		}
		});
	}

	public static void rock_ramp_l_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {29.369995,-41.184998},
			new NSArray(2) {11.73999,-34.11499}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {29.369995,-41.184998}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-40.924988,25.845001},
			new NSArray(2) {-45,45}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-37.01001,15.505005},
			new NSArray(2) {-40.924988,25.845001}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-32.434998,6.585022},
			new NSArray(2) {-37.01001,15.505005}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-24.164978,-6.039978},
			new NSArray(2) {-32.434998,6.585022}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-14.049988,-16.705017},
			new NSArray(2) {-24.164978,-6.039978}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-5.5599976,-23.559998},
			new NSArray(2) {-14.049988,-16.705017}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {11.73999,-34.11499},
			new NSArray(2) {-5.5599976,-23.559998}
		}
		});
	}

	public static void rock_ramp_xxs_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(3) {
			new NSArray(2) {14.974976,2.2349854},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {22.5,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {7.2199707,-1.5499878},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {14.974976,2.2349854}
		},
		new NSArray(3) {
			new NSArray(2) {-3.1599731,-4.8250122},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {7.2199707,-1.5499878}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {-3.1599731,-4.8250122}
		}
		});
	}

	public static void rock_ramp_xs_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(8) {
			new NSArray(2) {19.304993,6.8250122},
			new NSArray(2) {9.1199951,5.2349854},
			new NSArray(2) {-0.93499756,2.9849854},
			new NSArray(2) {-10.825012,0.075012207},
			new NSArray(2) {-20.5,-3.4699707},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void rock_ramp_s_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(3) {
			new NSArray(2) {35,7.375},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {45.5,15}
		},
		new NSArray(3) {
			new NSArray(2) {-23.025024,-12.61499},
			new NSArray(2) {0,-15},
			new NSArray(2) {-6.5050049,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {0,-15},
			new NSArray(2) {-23.025024,-12.61499}
		},
		new NSArray(3) {
			new NSArray(2) {21.97998,0.30999756},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {35,7.375}
		},
		new NSArray(4) {
			new NSArray(2) {7.8499756,-5.3150024},
			new NSArray(2) {0,-15},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {21.97998,0.30999756}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {7.8499756,-5.3150024},
			new NSArray(2) {-6.5050049,-9.5}
		}
		});
	}

	public static void rock_ramp_m_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(3) {
			new NSArray(2) {45.5,-30},
			new NSArray(2) {45.5,30},
			new NSArray(2) {38.700012,19.040009}
		},
		new NSArray(3) {
			new NSArray(2) {28.330017,6.2749939},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {38.700012,19.040009}
		},
		new NSArray(3) {
			new NSArray(2) {16.244995,-4.875},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {28.330017,6.2749939}
		},
		new NSArray(3) {
			new NSArray(2) {2.6950073,-14.190002},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {16.244995,-4.875}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {-27.679993,-26.585022}
		},
		new NSArray(3) {
			new NSArray(2) {-27.679993,-26.585022},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {-12.049988,-21.474976}
		},
		new NSArray(3) {
			new NSArray(2) {-12.049988,-21.474976},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {2.6950073,-14.190002}
		}
		});
	}

	public static void rock_ramp_l_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(3) {
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45},
			new NSArray(2) {40.924988,25.845001}
		},
		new NSArray(3) {
			new NSArray(2) {32.434998,6.5849915},
			new NSArray(2) {45,-45},
			new NSArray(2) {37.005005,15.505005}
		},
		new NSArray(3) {
			new NSArray(2) {24.164978,-6.0400085},
			new NSArray(2) {45,-45},
			new NSArray(2) {32.434998,6.5849915}
		},
		new NSArray(3) {
			new NSArray(2) {14.049988,-16.704987},
			new NSArray(2) {45,-45},
			new NSArray(2) {24.164978,-6.0400085}
		},
		new NSArray(3) {
			new NSArray(2) {-11.73999,-34.11499},
			new NSArray(2) {45,-45},
			new NSArray(2) {5.5599976,-23.559998}
		},
		new NSArray(3) {
			new NSArray(2) {5.5599976,-23.559998},
			new NSArray(2) {45,-45},
			new NSArray(2) {14.049988,-16.704987}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {-29.369995,-41.184998}
		},
		new NSArray(3) {
			new NSArray(2) {-29.369995,-41.184998},
			new NSArray(2) {45,-45},
			new NSArray(2) {-11.73999,-34.11499}
		},
		new NSArray(3) {
			new NSArray(2) {37.005005,15.505005},
			new NSArray(2) {45,-45},
			new NSArray(2) {40.924988,25.845001}
		}
		});
	}

	public static void sandstone_cube_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,30},
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30}
		}
		});
	}

	public static void sandstone_curve_eighth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {24.169983,-2.7750244},
			new NSArray(2) {42.35498,12.14502},
			new NSArray(2) {31.744995,22.755005},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {3.4199829,-13.86499}
		},
		new NSArray(5) {
			new NSArray(2) {-42.5,-8},
			new NSArray(2) {-42.5,-23},
			new NSArray(2) {-19.090027,-20.695007},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-22.015015,-5.9799805}
		},
		new NSArray(3) {
			new NSArray(2) {-22.015015,-5.9799805},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-2.3200073,-0.0050048828}
		},
		new NSArray(3) {
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {-2.3200073,-0.0050048828}
		}
		});
	}

	public static void sandstone_curve_eighth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(5) {
			new NSArray(2) {69.269989,15.650024},
			new NSArray(2) {84.704987,29.794983},
			new NSArray(2) {74.100006,40.400024},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {52.660004,2.9050293}
		},
		new NSArray(5) {
			new NSArray(2) {-85,-40.5},
			new NSArray(2) {-64.084991,-39.585022},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-85,-25.5}
		},
		new NSArray(4) {
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-45.929993,-22.080017}
		},
		new NSArray(4) {
			new NSArray(2) {52.660004,2.9050293},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {35,-8.3449707}
		},
		new NSArray(4) {
			new NSArray(2) {-45.929993,-22.080017},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-26.765015,-17.835022}
		},
		new NSArray(3) {
			new NSArray(2) {-26.765015,-17.835022},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(5) {
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {16.429993,-18.015015},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(3) {
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {27.5,4.6450195}
		},
		new NSArray(3) {
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {27.5,4.6450195}
		}
		});
	}

	public static void sandstone_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {57.695007,36.590027},
			new NSArray(2) {60,60},
			new NSArray(2) {45,60},
			new NSArray(2) {42.36499,36.63501},
			new NSArray(2) {50.86499,14.080017}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-45},
			new NSArray(2) {-60,-60},
			new NSArray(2) {-36.589996,-57.695007},
			new NSArray(2) {-14.079987,-50.86499},
			new NSArray(2) {-36.63501,-42.36499}
		},
		new NSArray(4) {
			new NSArray(2) {34.599976,14.440002},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {50.86499,14.080017},
			new NSArray(2) {42.36499,36.63501}
		},
		new NSArray(4) {
			new NSArray(2) {-36.63501,-42.36499},
			new NSArray(2) {-14.079987,-50.86499},
			new NSArray(2) {6.6700134,-39.775024},
			new NSArray(2) {-14.440002,-34.599976}
		},
		new NSArray(4) {
			new NSArray(2) {-14.440002,-34.599976},
			new NSArray(2) {6.6700134,-39.775024},
			new NSArray(2) {24.855011,-24.85498},
			new NSArray(2) {5.4649963,-22.090027}
		},
		new NSArray(4) {
			new NSArray(2) {5.4649963,-22.090027},
			new NSArray(2) {24.855011,-24.85498},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {22.089996,-5.4650269}
		},
		new NSArray(3) {
			new NSArray(2) {22.089996,-5.4650269},
			new NSArray(2) {39.775024,-6.6699829},
			new NSArray(2) {34.599976,14.440002}
		}
		});
	}

	public static void sandstone_curve_fourth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(15) {
		new NSArray(5) {
			new NSArray(2) {118.845,96.475006},
			new NSArray(2) {120,120},
			new NSArray(2) {105,120},
			new NSArray(2) {103.765,96.480011},
			new NSArray(2) {115.39,73.179993}
		},
		new NSArray(5) {
			new NSArray(2) {-120,-105},
			new NSArray(2) {-120,-120},
			new NSArray(2) {-96.474998,-118.84497},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-96.479996,-103.76501}
		},
		new NSArray(4) {
			new NSArray(2) {109.66499,50.329987},
			new NSArray(2) {115.39,73.179993},
			new NSArray(2) {103.765,96.480011},
			new NSArray(2) {100.08501,73.220001}
		},
		new NSArray(4) {
			new NSArray(2) {-96.479996,-103.76501},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-50.330002,-109.66498},
			new NSArray(2) {-73.220001,-100.08502}
		},
		new NSArray(4) {
			new NSArray(2) {-73.220001,-100.08502},
			new NSArray(2) {-50.330002,-109.66498},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-50.470001,-93.98999}
		},
		new NSArray(4) {
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {109.66499,50.329987},
			new NSArray(2) {100.08501,73.220001},
			new NSArray(2) {93.990005,50.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-50.470001,-93.98999},
			new NSArray(2) {-28.154999,-101.72998},
			new NSArray(2) {-6.8649979,-91.659973},
			new NSArray(2) {-28.485001,-85.549988}
		},
		new NSArray(4) {
			new NSArray(2) {-28.485001,-85.549988},
			new NSArray(2) {-6.8649979,-91.659973},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {-7.5,-74.85498}
		},
		new NSArray(4) {
			new NSArray(2) {-7.5,-74.85498},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {12.25,-62.030029}
		},
		new NSArray(5) {
			new NSArray(2) {30.554993,-47.210022},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {49.705002,-49.705017},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {47.210007,-30.554993}
		},
		new NSArray(3) {
			new NSArray(2) {12.25,-62.030029},
			new NSArray(2) {32.255005,-65.525024},
			new NSArray(2) {30.554993,-47.210022}
		},
		new NSArray(4) {
			new NSArray(2) {47.210007,-30.554993},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {62.029999,-12.25}
		},
		new NSArray(4) {
			new NSArray(2) {62.029999,-12.25},
			new NSArray(2) {79.554993,-13.335022},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(4) {
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {85.550003,28.484985},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {85.550003,28.484985},
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {93.990005,50.470001}
		}
		});
	}

	public static void sandstone_curve_sixteenth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {7.5599976,-7.4099731},
			new NSArray(2) {22.419983,-2.3649902},
			new NSArray(2) {16.679993,11.48999},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-7.835022,-10.474976}
		},
		new NSArray(4) {
			new NSArray(2) {-23.5,-11.5},
			new NSArray(2) {-7.835022,-10.474976},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-23.5,3.5}
		}
		});
	}

	public static void sandstone_curve_sixteenth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(5) {
			new NSArray(2) {30.64502,-3.7650146},
			new NSArray(2) {45.344971,1.769989},
			new NSArray(2) {39.60498,15.625},
			new NSArray(2) {23.030029,9.5100098},
			new NSArray(2) {15.61499,-8.3200073}
		},
		new NSArray(5) {
			new NSArray(2) {-46.5,-16.5},
			new NSArray(2) {-30.804993,-15.984985},
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {-28.844971,-0.80499268},
			new NSArray(2) {-46.5,-1.5}
		},
		new NSArray(4) {
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {-11.299988,1.269989},
			new NSArray(2) {-28.844971,-0.80499268}
		},
		new NSArray(4) {
			new NSArray(2) {15.61499,-8.3200073},
			new NSArray(2) {23.030029,9.5100098},
			new NSArray(2) {6.0250244,4.7149963},
			new NSArray(2) {0.32000732,-11.890015}
		},
		new NSArray(3) {
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {6.0250244,4.7149963},
			new NSArray(2) {-11.299988,1.269989}
		}
		});
	}

	public static void sandstone_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,7.5},
			new NSArray(2) {-45,-7.5},
			new NSArray(2) {45,-7.5},
			new NSArray(2) {45,7.5}
		}
		});
	}

	public static void sandstone_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,7.5},
			new NSArray(2) {-60,-7.5},
			new NSArray(2) {60,-7.5},
			new NSArray(2) {60,7.5}
		}
		});
	}

	public static void sandstone_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-120,7.5},
			new NSArray(2) {-120,-7.5},
			new NSArray(2) {120,-7.5},
			new NSArray(2) {120,7.5}
		}
		});
	}

	public static void wood_bump_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,3.5},
			new NSArray(2) {-5.3049927,1.3049927},
			new NSArray(2) {-7.5,-4},
			new NSArray(2) {7.5,-4},
			new NSArray(2) {5.3049927,1.3049927}
		}
		});
	}

	public static void wood_bump_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {-10.60498,2.605011},
			new NSArray(2) {-15,-8},
			new NSArray(2) {15,-8},
			new NSArray(2) {10.60498,2.605011},
			new NSArray(2) {0,7}
		}
		});
	}

	public static void wood_bump_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {11.47998,12.715027},
			new NSArray(2) {0,15},
			new NSArray(2) {-11.47998,12.715027},
			new NSArray(2) {-27.715027,-3.5200195},
			new NSArray(2) {-30,-15},
			new NSArray(2) {30,-15},
			new NSArray(2) {27.715027,-3.5200195},
			new NSArray(2) {21.215027,6.2150269}
		},
		new NSArray(3) {
			new NSArray(2) {-27.715027,-3.5200195},
			new NSArray(2) {-11.47998,12.715027},
			new NSArray(2) {-21.215027,6.2150269}
		}
		});
	}

	public static void wood_bump_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {11.64502,20.964996},
			new NSArray(2) {0,22.5},
			new NSArray(2) {-11.64502,20.964996},
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {43.465027,-10.855011},
			new NSArray(2) {38.969971,0},
			new NSArray(2) {31.820007,9.3200073},
			new NSArray(2) {22.5,16.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {-45,-22.5},
			new NSArray(2) {45,-22.5},
			new NSArray(2) {43.465027,-10.855011}
		},
		new NSArray(5) {
			new NSArray(2) {-38.969971,0},
			new NSArray(2) {-43.465027,-10.855011},
			new NSArray(2) {-11.64502,20.964996},
			new NSArray(2) {-22.5,16.470001},
			new NSArray(2) {-31.820007,9.3200073}
		}
		});
	}

	public static void wood_cube_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,15},
			new NSArray(2) {-15,-15},
			new NSArray(2) {15,-15},
			new NSArray(2) {15,15}
		}
		});
	}

	public static void wood_cube_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,30},
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30}
		}
		});
	}

	public static void wood_cube_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,45},
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45}
		}
		});
	}

	public static void wood_cube_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,60},
			new NSArray(2) {-60,-60},
			new NSArray(2) {60,-60},
			new NSArray(2) {60,60}
		}
		});
	}

	public static void wood_curve_eighth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {0.97998047,-7.7150269},
			new NSArray(2) {10.715027,-1.2150269},
			new NSArray(2) {0.10498047,9.3950195},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,-10}
		},
		new NSArray(3) {
			new NSArray(2) {-10.5,-10},
			new NSArray(2) {-4.7600098,6.1400146},
			new NSArray(2) {-10.5,5}
		}
		});
	}

	public static void wood_curve_eighth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-4.2800293,3.9250031},
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {1.460022,-9.9349976},
			new NSArray(2) {20.924988,3.0749969},
			new NSArray(2) {10.320007,13.68}
		},
		new NSArray(3) {
			new NSArray(2) {-21.5,-14.5},
			new NSArray(2) {-4.2800293,3.9250031},
			new NSArray(2) {-21.5,0.5}
		}
		});
	}

	public static void wood_curve_eighth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(5) {
			new NSArray(2) {24.169983,-2.7750244},
			new NSArray(2) {42.35498,12.14502},
			new NSArray(2) {31.744995,22.755005},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {3.4199829,-13.86499}
		},
		new NSArray(5) {
			new NSArray(2) {-42.5,-8},
			new NSArray(2) {-42.5,-23},
			new NSArray(2) {-19.090027,-20.695007},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-22.015015,-5.9799805}
		},
		new NSArray(3) {
			new NSArray(2) {-22.015015,-5.9799805},
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {-2.3200073,-0.0050048828}
		},
		new NSArray(3) {
			new NSArray(2) {3.4199829,-13.86499},
			new NSArray(2) {15.835022,9.6950073},
			new NSArray(2) {-2.3200073,-0.0050048828}
		}
		});
	}

	public static void wood_curve_eighth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(5) {
			new NSArray(2) {69.269989,15.650024},
			new NSArray(2) {84.704987,29.794983},
			new NSArray(2) {74.100006,40.400024},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {52.660004,2.9050293}
		},
		new NSArray(5) {
			new NSArray(2) {-85,-40.5},
			new NSArray(2) {-64.084991,-39.585022},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-85,-25.5}
		},
		new NSArray(4) {
			new NSArray(2) {-65.390015,-24.64502},
			new NSArray(2) {-43.325012,-36.85498},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-45.929993,-22.080017}
		},
		new NSArray(4) {
			new NSArray(2) {52.660004,2.9050293},
			new NSArray(2) {59.625,27.140015},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {35,-8.3449707}
		},
		new NSArray(4) {
			new NSArray(2) {-45.929993,-22.080017},
			new NSArray(2) {-22.88501,-32.320007},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-26.765015,-17.835022}
		},
		new NSArray(3) {
			new NSArray(2) {-26.765015,-17.835022},
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(5) {
			new NSArray(2) {-2.9150085,-26.025024},
			new NSArray(2) {16.429993,-18.015015},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {-8.0450134,-11.929993}
		},
		new NSArray(3) {
			new NSArray(2) {10.089996,-4.4199829},
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {27.5,4.6450195}
		},
		new NSArray(3) {
			new NSArray(2) {35,-8.3449707},
			new NSArray(2) {44.054993,15.190002},
			new NSArray(2) {27.5,4.6450195}
		}
		});
	}

	public static void wood_curve_fourth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(4) {
			new NSArray(2) {6.2150269,-6.2150269},
			new NSArray(2) {15,15},
			new NSArray(2) {0,15},
			new NSArray(2) {-4.3950195,4.3950195}
		},
		new NSArray(4) {
			new NSArray(2) {-15,0},
			new NSArray(2) {-15,-15},
			new NSArray(2) {6.2150269,-6.2150269},
			new NSArray(2) {-4.3950195,4.3950195}
		}
		});
	}

	public static void wood_curve_fourth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(5) {
			new NSArray(2) {25.434998,7.039978},
			new NSArray(2) {30,30},
			new NSArray(2) {15,30},
			new NSArray(2) {8.9699707,7.5},
			new NSArray(2) {12.424988,-12.424988}
		},
		new NSArray(5) {
			new NSArray(2) {-30,-15},
			new NSArray(2) {-30,-30},
			new NSArray(2) {-7.039978,-25.434998},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {-7.5,-8.9699707}
		},
		new NSArray(3) {
			new NSArray(2) {-7.5,-8.9699707},
			new NSArray(2) {12.424988,-12.424988},
			new NSArray(2) {8.9699707,7.5}
		}
		});
	}

	public static void wood_curve_fourth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(5) {
			new NSArray(2) {57.695007,36.589996},
			new NSArray(2) {60,60},
			new NSArray(2) {45,60},
			new NSArray(2) {42.36499,36.63501},
			new NSArray(2) {50.86499,14.079987}
		},
		new NSArray(5) {
			new NSArray(2) {-60,-45},
			new NSArray(2) {-60,-60},
			new NSArray(2) {-36.589996,-57.695007},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {-36.63501,-42.36499}
		},
		new NSArray(4) {
			new NSArray(2) {34.599976,14.440002},
			new NSArray(2) {39.775024,-6.6700134},
			new NSArray(2) {50.86499,14.079987},
			new NSArray(2) {42.36499,36.63501}
		},
		new NSArray(4) {
			new NSArray(2) {-36.63501,-42.36499},
			new NSArray(2) {-14.080017,-50.86499},
			new NSArray(2) {6.6699829,-39.774994},
			new NSArray(2) {-14.440002,-34.600006}
		},
		new NSArray(4) {
			new NSArray(2) {-14.440002,-34.600006},
			new NSArray(2) {6.6699829,-39.774994},
			new NSArray(2) {24.85498,-24.855011},
			new NSArray(2) {5.4650269,-22.089996}
		},
		new NSArray(4) {
			new NSArray(2) {5.4650269,-22.089996},
			new NSArray(2) {24.85498,-24.855011},
			new NSArray(2) {39.775024,-6.6700134},
			new NSArray(2) {22.090027,-5.4649963}
		},
		new NSArray(3) {
			new NSArray(2) {22.090027,-5.4649963},
			new NSArray(2) {39.775024,-6.6700134},
			new NSArray(2) {34.599976,14.440002}
		}
		});
	}

	public static void wood_curve_fourth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(15) {
		new NSArray(5) {
			new NSArray(2) {118.845,96.475006},
			new NSArray(2) {120,120},
			new NSArray(2) {105,120},
			new NSArray(2) {103.765,96.479996},
			new NSArray(2) {115.39,73.179993}
		},
		new NSArray(5) {
			new NSArray(2) {-120,-105},
			new NSArray(2) {-120,-120},
			new NSArray(2) {-96.474998,-118.845},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-96.479996,-103.76501}
		},
		new NSArray(4) {
			new NSArray(2) {109.66499,50.330002},
			new NSArray(2) {115.39,73.179993},
			new NSArray(2) {103.765,96.479996},
			new NSArray(2) {100.08501,73.220001}
		},
		new NSArray(4) {
			new NSArray(2) {-96.479996,-103.76501},
			new NSArray(2) {-73.18,-115.39001},
			new NSArray(2) {-50.330002,-109.66501},
			new NSArray(2) {-73.220001,-100.08499}
		},
		new NSArray(4) {
			new NSArray(2) {-73.220001,-100.08499},
			new NSArray(2) {-50.330002,-109.66501},
			new NSArray(2) {-28.154999,-101.73001},
			new NSArray(2) {-50.470001,-93.98999}
		},
		new NSArray(4) {
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {109.66499,50.330002},
			new NSArray(2) {100.08501,73.220001},
			new NSArray(2) {93.990005,50.470001}
		},
		new NSArray(4) {
			new NSArray(2) {-50.470001,-93.98999},
			new NSArray(2) {-28.154999,-101.73001},
			new NSArray(2) {-6.8649979,-91.660004},
			new NSArray(2) {-28.485001,-85.549988}
		},
		new NSArray(4) {
			new NSArray(2) {-28.485001,-85.549988},
			new NSArray(2) {-6.8649979,-91.660004},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {-7.5,-74.855011}
		},
		new NSArray(4) {
			new NSArray(2) {-7.5,-74.855011},
			new NSArray(2) {13.335007,-79.554993},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {12.25,-62.029999}
		},
		new NSArray(5) {
			new NSArray(2) {30.554993,-47.209991},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {49.705002,-49.704987},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {47.210007,-30.554993}
		},
		new NSArray(3) {
			new NSArray(2) {12.25,-62.029999},
			new NSArray(2) {32.255005,-65.524994},
			new NSArray(2) {30.554993,-47.209991}
		},
		new NSArray(4) {
			new NSArray(2) {47.210007,-30.554993},
			new NSArray(2) {65.524994,-32.255005},
			new NSArray(2) {79.554993,-13.334991},
			new NSArray(2) {62.029999,-12.25}
		},
		new NSArray(4) {
			new NSArray(2) {62.029999,-12.25},
			new NSArray(2) {79.554993,-13.334991},
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(4) {
			new NSArray(2) {91.660004,6.8649902},
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {85.550003,28.485001},
			new NSArray(2) {74.854996,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {85.550003,28.485001},
			new NSArray(2) {101.73,28.154999},
			new NSArray(2) {93.990005,50.470001}
		}
		});
	}

	public static void wood_curve_sixteenth_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.65002441,-7.4249878},
			new NSArray(2) {4.9799805,-5.7149963},
			new NSArray(2) {-0.76000977,8.1400146},
			new NSArray(2) {-3.5750122,7.2900085},
			new NSArray(2) {-6.5,-8}
		},
		new NSArray(3) {
			new NSArray(2) {-6.5,-8},
			new NSArray(2) {-3.5750122,7.2900085},
			new NSArray(2) {-6.5,7}
		}
		});
	}

	public static void wood_curve_sixteenth_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {-0.29498291,-8.3449707},
			new NSArray(2) {10.960022,-4.9349976},
			new NSArray(2) {5.2199707,8.9249878},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-12,-9.5},
			new NSArray(2) {-3.2199707,6.3649902},
			new NSArray(2) {-12,5.5}
		}
		});
	}

	public static void wood_curve_sixteenth_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(5) {
			new NSArray(2) {7.5599976,-7.4099731},
			new NSArray(2) {22.419983,-2.3649902},
			new NSArray(2) {16.679993,11.48999},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-7.835022,-10.474976}
		},
		new NSArray(4) {
			new NSArray(2) {-23.5,-11.5},
			new NSArray(2) {-7.835022,-10.474976},
			new NSArray(2) {-3.0150146,5.5200195},
			new NSArray(2) {-23.5,3.5}
		}
		});
	}

	public static void wood_curve_sixteenth_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(5) {
		new NSArray(5) {
			new NSArray(2) {30.644989,-3.7650146},
			new NSArray(2) {45.344971,1.7700195},
			new NSArray(2) {39.60498,15.625},
			new NSArray(2) {23.029999,9.5150146},
			new NSArray(2) {15.61499,-8.3200073}
		},
		new NSArray(5) {
			new NSArray(2) {-46.5,-16.5},
			new NSArray(2) {-30.804993,-15.984985},
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {-28.845001,-0.80499268},
			new NSArray(2) {-46.5,-1.5}
		},
		new NSArray(4) {
			new NSArray(2) {-15.174988,-14.445007},
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {-11.299988,1.2700195},
			new NSArray(2) {-28.845001,-0.80499268}
		},
		new NSArray(4) {
			new NSArray(2) {15.61499,-8.3200073},
			new NSArray(2) {23.029999,9.5150146},
			new NSArray(2) {6.0249939,4.7150269},
			new NSArray(2) {0.32000732,-11.890015}
		},
		new NSArray(3) {
			new NSArray(2) {0.32000732,-11.890015},
			new NSArray(2) {6.0249939,4.7150269},
			new NSArray(2) {-11.299988,1.2700195}
		}
		});
	}

	public static void wood_flat_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-7.5,7.5},
			new NSArray(2) {-7.5,-7.5},
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5}
		}
		});
	}

	public static void wood_flat_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-15,7.5},
			new NSArray(2) {-15,-7.5},
			new NSArray(2) {15,-7.5},
			new NSArray(2) {15,7.5}
		}
		});
	}

	public static void wood_flat_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-30,7.5},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void wood_flat_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-45,7.5},
			new NSArray(2) {-45,-7.5},
			new NSArray(2) {45,-7.5},
			new NSArray(2) {45,7.5}
		}
		});
	}

	public static void wood_flat_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-60,7.5},
			new NSArray(2) {-60,-7.5},
			new NSArray(2) {60,-7.5},
			new NSArray(2) {60,7.5}
		}
		});
	}

	public static void wood_flat_xxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-120,7.5},
			new NSArray(2) {-120,-7.5},
			new NSArray(2) {120,-7.5},
			new NSArray(2) {120,7.5}
		}
		});
	}

	public static void wood_flat_xxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-240,7.5},
			new NSArray(2) {-240,-7.5},
			new NSArray(2) {240,-7.5},
			new NSArray(2) {240,7.5}
		}
		});
	}

	public static void wood_flat_xxxxl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {-480,7.5},
			new NSArray(2) {-480,-7.5},
			new NSArray(2) {480,-7.5},
			new NSArray(2) {480,7.5}
		}
		});
	}

	public static void wood_hump_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,2.5},
			new NSArray(2) {-4.25,1.3599854},
			new NSArray(2) {-7.5,-2.5},
			new NSArray(2) {7.5,-2.5},
			new NSArray(2) {4.25,1.3599854}
		}
		});
	}

	public static void wood_hump_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(5) {
			new NSArray(2) {0,4},
			new NSArray(2) {-9.1550293,1.7150269},
			new NSArray(2) {-15,-4},
			new NSArray(2) {15,-4},
			new NSArray(2) {9.1550293,1.7150269}
		}
		});
	}

	public static void wood_hump_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(7) {
			new NSArray(2) {0,5},
			new NSArray(2) {-10.210022,4.0150146},
			new NSArray(2) {-20.039978,1.1049805},
			new NSArray(2) {-30,-5},
			new NSArray(2) {30,-5},
			new NSArray(2) {20.039978,1.1049805},
			new NSArray(2) {10.210022,4.0150146}
		}
		});
	}

	public static void wood_hump_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {0,6},
			new NSArray(2) {-12.125,5.2249756},
			new NSArray(2) {-24.054993,2.9050293},
			new NSArray(2) {-45,-6},
			new NSArray(2) {45,-6},
			new NSArray(2) {35.590027,-0.91998291},
			new NSArray(2) {24.054993,2.9050293},
			new NSArray(2) {12.125,5.2249756}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-6},
			new NSArray(2) {-24.054993,2.9050293},
			new NSArray(2) {-35.590027,-0.91998291}
		}
		});
	}

	public static void wood_pie_quarter_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(4) {
			new NSArray(2) {7.5,-7.5},
			new NSArray(2) {7.5,7.5},
			new NSArray(2) {-3.1049805,3.1049805},
			new NSArray(2) {-7.5,-7.5}
		}
		});
	}

	public static void wood_pie_quarter_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(6) {
			new NSArray(2) {15,-15},
			new NSArray(2) {15,15},
			new NSArray(2) {3.5200195,12.715027},
			new NSArray(2) {-6.2150269,6.2150269},
			new NSArray(2) {-12.715027,-3.5200195},
			new NSArray(2) {-15,-15}
		}
		});
	}

	public static void wood_pie_quarter_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(2) {
		new NSArray(8) {
			new NSArray(2) {30,-30},
			new NSArray(2) {30,30},
			new NSArray(2) {18.294983,28.844971},
			new NSArray(2) {7.039978,25.434998},
			new NSArray(2) {-3.335022,19.890015},
			new NSArray(2) {-12.424988,12.424988},
			new NSArray(2) {-19.890015,3.335022},
			new NSArray(2) {-25.434998,-7.039978}
		},
		new NSArray(4) {
			new NSArray(2) {-30,-30},
			new NSArray(2) {30,-30},
			new NSArray(2) {-25.434998,-7.039978},
			new NSArray(2) {-28.844971,-18.294983}
		}
		});
	}

	public static void wood_pie_quarter_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(7) {
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45},
			new NSArray(2) {33.255005,44.230011},
			new NSArray(2) {21.705017,41.934998},
			new NSArray(2) {10.559998,38.149994},
			new NSArray(2) {0,32.940002},
			new NSArray(2) {-9.789978,26.399994}
		},
		new NSArray(8) {
			new NSArray(2) {-18.640015,18.640015},
			new NSArray(2) {-26.400024,9.7900085},
			new NSArray(2) {-32.940002,0},
			new NSArray(2) {-38.150024,-10.559998},
			new NSArray(2) {-41.934998,-21.704987},
			new NSArray(2) {-44.22998,-33.255005},
			new NSArray(2) {45,-45},
			new NSArray(2) {-9.789978,26.399994}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {-44.22998,-33.255005}
		}
		});
	}

	public static void wood_pie_quarter_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(3) {
		new NSArray(8) {
			new NSArray(2) {-24.85498,24.855011},
			new NSArray(2) {-32.76001,16.125},
			new NSArray(2) {-39.774994,6.6700134},
			new NSArray(2) {-45.829987,-3.4299927},
			new NSArray(2) {-50.86499,-14.079987},
			new NSArray(2) {60,-60},
			new NSArray(2) {-6.6699829,39.774994},
			new NSArray(2) {-16.125,32.76001}
		},
		new NSArray(8) {
			new NSArray(2) {25.164978,54.834991},
			new NSArray(2) {14.080017,50.86499},
			new NSArray(2) {3.4299927,45.829987},
			new NSArray(2) {-6.6699829,39.774994},
			new NSArray(2) {60,-60},
			new NSArray(2) {60,60},
			new NSArray(2) {48.23999,59.420013},
			new NSArray(2) {36.590027,57.695007}
		},
		new NSArray(6) {
			new NSArray(2) {-60,-60},
			new NSArray(2) {60,-60},
			new NSArray(2) {-50.86499,-14.079987},
			new NSArray(2) {-54.834991,-25.165009},
			new NSArray(2) {-57.695007,-36.589996},
			new NSArray(2) {-59.420013,-48.23999}
		}
		});
	}

	public static void wood_pyramid_xs(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-7.5,-4},
			new NSArray(2) {7.5,-4},
			new NSArray(2) {0,4}
		}
		});
	}

	public static void wood_pyramid_s(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-15,-8},
			new NSArray(2) {15,-8},
			new NSArray(2) {0,8}
		}
		});
	}

	public static void wood_pyramid_m(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-30,-15.5},
			new NSArray(2) {30,-15.5},
			new NSArray(2) {0,15.5}
		}
		});
	}

	public static void wood_pyramid_l(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-45,-23},
			new NSArray(2) {45,-23},
			new NSArray(2) {0,23}
		}
		});
	}

	public static void wood_pyramid_xl(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(3) {
			new NSArray(2) {-60,-30.5},
			new NSArray(2) {60,-30.5},
			new NSArray(2) {0,30.5}
		}
		});
	}

	public static void wood_ramp_xxs_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {3.1599731,-4.8250122}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {3.1599731,-4.8250122},
			new NSArray(2) {-7.2199707,-1.5499878}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {-14.974976,2.2349854},
			new NSArray(2) {-22.5,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {-7.2199707,-1.5499878},
			new NSArray(2) {-14.974976,2.2349854}
		}
		});
	}

	public static void wood_ramp_xs_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(8) {
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {20.5,-3.4699707},
			new NSArray(2) {10.825012,0.075012207},
			new NSArray(2) {0.93499756,2.9849854},
			new NSArray(2) {-9.1199951,5.2349854},
			new NSArray(2) {-19.304993,6.8250122},
			new NSArray(2) {-30,7.5}
		}
		});
	}

	public static void wood_ramp_s_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(4) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {0,-15},
			new NSArray(2) {-7.8500061,-5.3150024},
			new NSArray(2) {-21.980011,0.30999756}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {23.024994,-12.61499}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {-35,7.375},
			new NSArray(2) {-45.5,15}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {-21.980011,0.30999756},
			new NSArray(2) {-35,7.375}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {23.024994,-12.61499},
			new NSArray(2) {6.5050049,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {6.5050049,-9.5},
			new NSArray(2) {-7.8500061,-5.3150024}
		}
		});
	}

	public static void wood_ramp_m_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {27.679993,-26.584991},
			new NSArray(2) {12.049988,-21.475006}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {27.679993,-26.584991}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-38.700012,19.040009},
			new NSArray(2) {-45.5,30}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-28.330017,6.2749939},
			new NSArray(2) {-38.700012,19.040009}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-16.244995,-4.875},
			new NSArray(2) {-28.330017,6.2749939}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {-2.6950073,-14.190002},
			new NSArray(2) {-16.244995,-4.875}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {12.049988,-21.475006},
			new NSArray(2) {-2.6950073,-14.190002}
		}
		});
	}

	public static void wood_ramp_l_left(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {29.369995,-41.184998},
			new NSArray(2) {11.73999,-34.115005}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {29.369995,-41.184998}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-40.924988,25.845001},
			new NSArray(2) {-45,45}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-37.01001,15.505005},
			new NSArray(2) {-40.924988,25.845001}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-32.434998,6.5850067},
			new NSArray(2) {-37.01001,15.505005}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-24.164978,-6.0399933},
			new NSArray(2) {-32.434998,6.5850067}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-14.049988,-16.705002},
			new NSArray(2) {-24.164978,-6.0399933}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {-5.5599976,-23.559998},
			new NSArray(2) {-14.049988,-16.705002}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {11.73999,-34.115005},
			new NSArray(2) {-5.5599976,-23.559998}
		}
		});
	}

	public static void wood_ramp_xxs_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(4) {
		new NSArray(3) {
			new NSArray(2) {14.974976,2.2349854},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {22.5,7.5}
		},
		new NSArray(3) {
			new NSArray(2) {7.2199707,-1.5499878},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {14.974976,2.2349854}
		},
		new NSArray(3) {
			new NSArray(2) {-3.1599731,-4.8250122},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {7.2199707,-1.5499878}
		},
		new NSArray(3) {
			new NSArray(2) {-22.5,-7.5},
			new NSArray(2) {22.5,-7.5},
			new NSArray(2) {-3.1599731,-4.8250122}
		}
		});
	}

	public static void wood_ramp_xs_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(1) {
		new NSArray(8) {
			new NSArray(2) {19.304993,6.8250122},
			new NSArray(2) {9.1199951,5.2349854},
			new NSArray(2) {-0.93499756,2.9849854},
			new NSArray(2) {-10.825012,0.075012207},
			new NSArray(2) {-20.5,-3.4699707},
			new NSArray(2) {-30,-7.5},
			new NSArray(2) {30,-7.5},
			new NSArray(2) {30,7.5}
		}
		});
	}

	public static void wood_ramp_s_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(6) {
		new NSArray(3) {
			new NSArray(2) {35,7.375},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {45.5,15}
		},
		new NSArray(3) {
			new NSArray(2) {-23.024994,-12.61499},
			new NSArray(2) {0,-15},
			new NSArray(2) {-6.5050049,-9.5}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-15},
			new NSArray(2) {0,-15},
			new NSArray(2) {-23.024994,-12.61499}
		},
		new NSArray(3) {
			new NSArray(2) {21.980011,0.30999756},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {35,7.375}
		},
		new NSArray(4) {
			new NSArray(2) {7.8500061,-5.3150024},
			new NSArray(2) {0,-15},
			new NSArray(2) {45.5,-15},
			new NSArray(2) {21.980011,0.30999756}
		},
		new NSArray(3) {
			new NSArray(2) {0,-15},
			new NSArray(2) {7.8500061,-5.3150024},
			new NSArray(2) {-6.5050049,-9.5}
		}
		});
	}

	public static void wood_ramp_m_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(7) {
		new NSArray(3) {
			new NSArray(2) {45.5,-30},
			new NSArray(2) {45.5,30},
			new NSArray(2) {38.700012,19.039978}
		},
		new NSArray(3) {
			new NSArray(2) {28.330017,6.2750244},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {38.700012,19.039978}
		},
		new NSArray(3) {
			new NSArray(2) {16.244995,-4.875},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {28.330017,6.2750244}
		},
		new NSArray(3) {
			new NSArray(2) {2.6950073,-14.190002},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {16.244995,-4.875}
		},
		new NSArray(3) {
			new NSArray(2) {-45.5,-30},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {-27.679993,-26.585022}
		},
		new NSArray(3) {
			new NSArray(2) {-27.679993,-26.585022},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {-12.049988,-21.474976}
		},
		new NSArray(3) {
			new NSArray(2) {-12.049988,-21.474976},
			new NSArray(2) {45.5,-30},
			new NSArray(2) {2.6950073,-14.190002}
		}
		});
	}

	public static void wood_ramp_l_right(NSDictionary physProps)
	{
		physProps.Add("ShapeFixtures", new NSArray(9) {
		new NSArray(3) {
			new NSArray(2) {45,-45},
			new NSArray(2) {45,45},
			new NSArray(2) {40.924988,25.845001}
		},
		new NSArray(3) {
			new NSArray(2) {32.434998,6.5849991},
			new NSArray(2) {45,-45},
			new NSArray(2) {37.005005,15.504997}
		},
		new NSArray(3) {
			new NSArray(2) {24.164978,-6.0400009},
			new NSArray(2) {45,-45},
			new NSArray(2) {32.434998,6.5849991}
		},
		new NSArray(3) {
			new NSArray(2) {14.049988,-16.705002},
			new NSArray(2) {45,-45},
			new NSArray(2) {24.164978,-6.0400009}
		},
		new NSArray(3) {
			new NSArray(2) {-11.73999,-34.115005},
			new NSArray(2) {45,-45},
			new NSArray(2) {5.5599976,-23.559998}
		},
		new NSArray(3) {
			new NSArray(2) {5.5599976,-23.559998},
			new NSArray(2) {45,-45},
			new NSArray(2) {14.049988,-16.705002}
		},
		new NSArray(3) {
			new NSArray(2) {-45,-45},
			new NSArray(2) {45,-45},
			new NSArray(2) {-29.369995,-41.184998}
		},
		new NSArray(3) {
			new NSArray(2) {-29.369995,-41.184998},
			new NSArray(2) {45,-45},
			new NSArray(2) {-11.73999,-34.115005}
		},
		new NSArray(3) {
			new NSArray(2) {37.005005,15.504997},
			new NSArray(2) {45,-45},
			new NSArray(2) {40.924988,25.845001}
		}
		});
	}


}
