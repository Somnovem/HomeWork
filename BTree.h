#pragma once
#include<iostream>
using namespace std;

template<class TKey,class TVal>
class BTreeNode
{
public:
	TKey key;
	TVal value;
	BTreeNode* left = nullptr;
	BTreeNode* right = nullptr;
	BTreeNode() {}
	BTreeNode(TKey key, TVal val) : key{ key }, value{ val } {}
	BTreeNode(const BTreeNode& btrn) noexcept
	{
		this->key = btrn.key;
		this->value = btrn.value;
		this->left = btrn.left;
		this->right = btrn.right;
	}
	void print(const BTreeNode<TKey,TVal>* root,const string& separator) const noexcept
	{
		if (root)
		{
			if (root->left)
			{
				print(root->left,separator);
			}
			root->value.print();
			cout << separator;
			if (root->right)
			{
				print(root->right,separator);
			}
		}
	}
	void del()
	{
		if (left != nullptr)
		{
		left->del();
		left = nullptr;
		}
		if (right != nullptr)
		{
			right->del();
			right = nullptr;
		}
		delete this;
	}
	TVal* getValue(const TKey& key) noexcept
	{
		if (key == this->key) return &value;
		if (key < this->key && left != nullptr) return left->getValue(key);
		if (key > this->key && right != nullptr) return right->getValue(key);
		return nullptr;
	}
	void save(ofstream& out);
	BTreeNode& operator=(const BTreeNode& btrn)
	{
		if (&btrn == this)
		{
			return *this;
		}
		if (!this)
		{
			free(this);
		}
		this->key = btrn.key;
		this->value = btrn.value;
		this->left = btrn.left;
		this->right = btrn.right;
		return *this;
	}

	BTreeNode* findNode(const TKey& key)
	{
		if (key == this->key) return this;
		if (key < this->key && left != nullptr) return left->findNode(key);
		if (key > this->key && right != nullptr) return right->findNode(key);
		return nullptr;
	}
	BTreeNode* minValueNode(BTreeNode* node)
	{
		BTreeNode<TKey, TVal>* current = node;
		while (current && current->left!=nullptr)
		{
			current = current->left;
		}
		return current;
	}
	void deleteNode(BTreeNode*& root, TKey key)
	{
		BTreeNode* parent = nullptr;

		BTreeNode* curr = root;

		searchKey(curr, key, parent);

		if (curr == nullptr)
		{
			return;
		}

		if (curr->left == nullptr && curr->right == nullptr)
		{
			if (curr != root)
			{
				if (parent->left == curr) {
					parent->left = nullptr;
				}
				else {
					parent->right = nullptr;
				}
			}
			else {
				root = nullptr;
			}
			free(curr); 
		}
		else if (curr->left && curr->right)
		{
			BTreeNode* successor = minValueNode(curr->right);

			// store successor value
			TKey val = successor->key;
			TVal value = successor->value;
			deleteNode(root, successor->key);

			// copy value of the successor to the current node
			curr->key = val;
			curr->value = value;
		}
		else {
			BTreeNode* child = (curr->left) ? curr->left : curr->right;
			if (curr != root)
			{
				if (curr == parent->left) {
					parent->left = child;
				}
				else {
					parent->right = child;
				}
			}
			else {
				root = child;
			}
			free(curr);
		}
	}
	void searchKey(BTreeNode*& curr, TKey key, BTreeNode*& parent)
	{
		while (curr != nullptr && curr->key != key)
		{
			parent = curr;
			if (key < curr->key) {
				curr = curr->left;
			}
			else {
				curr = curr->right;
			}
		}
	}
};

template<class TKey, class TVal>
class BTree
{
	BTreeNode<TKey, TVal>* root = nullptr;
	BTreeNode<TKey, TVal>* push_r(TKey key, TVal value, BTreeNode<TKey, TVal>*& node);
public:
	~BTree();
	bool push(TKey& key, TVal& value);
	BTreeNode<TKey, TVal>* rpush(TKey key, TVal value);
	void print(const string& separator);
	bool isEmpty();
	TVal* getValue(const TKey& key);
	BTreeNode<TKey, TVal>* getRoot() { return root; }
	void clear();
	BTreeNode<TKey, TVal>* getNodeByKey(TKey key);
	void pop(TKey key);
};

template<class TKey, class TVal>
BTree<TKey, TVal>::~BTree()
{
	this->clear();
}

template<class TKey, class TVal>
bool BTree<TKey, TVal>::push(TKey& key, TVal& value)
{
	if (!root)
	{
		root = new BTreeNode<TKey, TVal>(key,value);
		return true;
	}
	BTreeNode<TKey, TVal>* next = root;
	do
	{
		if (key < next->key)
		{
			if (next->left)
			{
				next = next->left;
			}
			else
			{
				next->left = new BTreeNode<TKey, TVal>(key, value);
				return true;
			}
		}
		else if (key > next->key)
		{
			if (next->right)
			{
				next = next->right;
			}
			else
			{
				next->right = new BTreeNode<TKey, TVal>(key, value);
				return true;
			}
		}
	} while (true);
	return false;
}

template<class TKey, class TVal>
void BTree<TKey, TVal>::pop(TKey key)
{
	root->deleteNode(root, key);
}

template<class TKey, class TVal>
BTreeNode<TKey, TVal>* BTree<TKey, TVal>::push_r(TKey key, TVal value, BTreeNode<TKey,TVal>*& node)
{
	if (!node)
	{
		node = new BTreeNode<TKey, TVal>(key, value);
		return node;
	}
	if (key < node->key)
		node->left = push_r(key, value, node->left);
	else if (key > node->key)
		node->right = push_r(key, value, node->right);
	return node;
}

template<class TKey, class TVal>
BTreeNode<TKey, TVal>* BTree<TKey, TVal>::rpush(TKey key, TVal value)
{
	return push_r(key,value,root);
}

template<class TKey, class TVal>
void BTree<TKey, TVal>::clear()
{
	if (root)
	{
		root->del();
		root = nullptr;
	}
}

template<class TKey, class TVal>
bool BTree<TKey, TVal>::isEmpty()
{
	return root == nullptr;
}

template<class TKey, class TVal>
TVal* BTree<TKey, TVal>::getValue(const TKey& key)
{
	if (root)
	{
		return root->getValue(key);
	}
	return nullptr;
}

template<class TKey, class TVal>
void BTree<TKey, TVal>::print(const string& separator)
{
	system("cls");
	if (root)
		root->print(root,separator);
	else cout << "Empty list" << endl;

}

template<class TKey, class TVal>
BTreeNode<TKey, TVal>* BTree<TKey, TVal>::getNodeByKey(TKey key)
{
	return root->findNode(key);
}

template<class TKey, class TVal>
void BTreeNode<TKey, TVal>::save(ofstream& out)
{
	if (this)
	{
		value.save(out);
	}
	if (left)
	{
		left->save(out);
	}
	if (right)
	{
		right->save(out);
	}
}
