#pragma once

#include "XATF.h"
#include "model_object.h"
#include "texture_manager.h"

class window_manager
{
public:
	bool init(const int width, const int height, texture_manager * t_manager)
	{
		if (!glfwInit()) {
			return false;
		}

		m_window = glfwCreateWindow(width, height, APP_NAME, nullptr, nullptr);

		if (!m_window)
		{
			glfwTerminate();
			return false;
		}



		glfwMakeContextCurrent(m_window);

		m_texture_manager = t_manager;

		return true;
	}

	void add_model(model_object obj)
	{
		obj.init(m_texture_manager);

		m_objects.push_back(obj);
	}

	void render()
	{
		while (!glfwWindowShouldClose(m_window))
		{
			glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

			glLoadIdentity();

			glClearColor(0.0, 0.0, 0.0, 0.0);

			for (auto x = m_objects.begin(); x != m_objects.end(); ++x)
			{
				x->render();
			}

			glfwSwapBuffers(m_window);

			glfwPollEvents();
		}
	}

	void shutdown()
	{
		m_window = nullptr;

		glfwTerminate();

	}
private:
	GLFWwindow * m_window = nullptr;
	std::list<model_object> m_objects;
	texture_manager * m_texture_manager;
};
