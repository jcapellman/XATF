#pragma once

#include "XATF.h"
#include "model_object.h"

class window_manager
{
public:
	bool init(const int width, const int height)
	{
		if (!glfwInit()) {
			return false;
		}

		m_window = glfwCreateWindow(width, height, "XATF", nullptr, nullptr);

		if (!m_window)
		{
			glfwTerminate();
			return false;
		}

		glfwMakeContextCurrent(m_window);

		return true;
	}

	void add_model(const model_object obj)
	{
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
				x->Render();
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
};
