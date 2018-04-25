#include "XATF.h"

#include "window_manager.h"
#include "texture_manager.h"

int main(void)
{
	window_manager w_manager;
	texture_manager t_manager;

	if (!w_manager.init(1280, 720, &t_manager))
	{
		return 0;
	}

	w_manager.add_model(model_object());

	w_manager.render();

	w_manager.shutdown();

	return 0;
}
